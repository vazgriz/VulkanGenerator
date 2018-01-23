using System;
using System.Text;
using System.Collections.Generic;

using SpecReader;

namespace CppGenerator {
    public class CppEnum {
        public List<CppEnumValue> Values { get; private set; }

        public string Name { get; private set; }

        public CppEnum(SpecReader.Enum e) {
            Name = FixName(e.Name).Substring(2);

            Values = new List<CppEnumValue>();

            if (Name.Contains("Flags")) {
                bool hasNone = false;
                foreach (var v in e.Values) {
                    if (v.Name.Contains("NONE")) {
                        hasNone = true;
                        break;
                    }
                }

                if (!hasNone) {
                    Values.Add(new CppEnumValue("None"));
                }
            }

            foreach (var v in e.Values) {
                Values.Add(new CppEnumValue(e, v));
            }
        }

        string FixName(string name) {
            int index = name.IndexOf("FlagBits");

            if (index != -1) {
                string flagNames = name.Substring(0, index);
                flagNames += "Flags";
                if (name.Length > index + 8) flagNames += name.Substring(index + 8, name.Length - (index + 8)); //preserve extension postfix

                return flagNames;
            } else {
                return name;
            }
        }
    }

    public class CppEnumValue {
        public string Name { get; private set; }

        public CppEnumValue(SpecReader.Enum e, EnumValue v) {
            Name = GetName(e, v);
        }

        public CppEnumValue(string name) {
            Name = name;
        }

        string GetName(SpecReader.Enum e, EnumValue v) {
            var enumNames = Split(e.Name);
            List<string> tokens = new List<string>(v.Name.Split('_'));
            StringBuilder builder = new StringBuilder();

            for (int i = tokens.Count - 1; i >= 0; i--) {
                if (tokens[i] == "VK" || tokens[i] == "BIT") {
                    tokens.RemoveAt(i);
                }
            }

            bool underscoreLast = false;
            int emitted = 0;

            for (int i = 0; i < tokens.Count; i++) {
                var token = tokens[i];
                if (enumNames.Contains(token.ToUpper())) {    //strip name of enum from enum value (eg STRUCTURE_TYPE_INSTANCE_CREATE_INFO -> INSTANCE_CREATE_INFO)
                    enumNames.Remove(token);
                    continue;
                }
                EmitValue(builder, token, emitted == 0, i, tokens.Count, ref underscoreLast);
                emitted++;
            }

            return builder.ToString();
        }

        void EmitValue(StringBuilder builder, string token, bool first, int index, int count, ref bool underscoreLast) {
            //capitalize first letter and lowercase every other letter
            //except if token contains numbers

            bool hasNumbers = false;
            bool hasLetters = false;

            for (int i = 0; i < token.Length; i++) {
                if (char.IsDigit(token[i])) {
                    hasNumbers = true;
                }
                if (char.IsLetter(token[i])) {
                    hasLetters = true;
                }
            }

            //prepend underscore only if last emit did not append underscore and token has numbers
            if (!underscoreLast && hasNumbers) {
                //no letters or (letters but not first token) or (first char is digit and first token)
                if (!hasLetters || (hasLetters && !first) || (char.IsDigit(token[0]) && first)) {
                    builder.Append("_");
                }
            }

            if (hasNumbers) {
                builder.Append(token);
                if (index != count - 1) builder.Append("_");
                underscoreLast = true;
            } else {
                builder.Append(char.ToUpper(token[0]));
                for (int i = 1; i < token.Length; i++) {    //every other letter
                    builder.Append(char.ToLower(token[i]));
                }
                underscoreLast = false;
            }
        }

        HashSet<string> Split(string enumName) {
            enumName = enumName.Substring(2);   //strip "Vk" from enum name
            StringBuilder builder = new StringBuilder();
            List<string> tokens = new List<string>();

            int upperCount = 0;

            for (int i = 0; i < enumName.Length; i++) {
                char c = enumName[i];
                if (char.IsUpper(c)) {
                    if (upperCount == 0) {
                        Flush(tokens, builder);
                        upperCount++;
                    }
                } else {
                    upperCount = 0;
                }

                builder.Append(char.ToUpper(c));
            }

            Flush(tokens, builder);

            return new HashSet<string>(tokens);
        }

        void Flush(List<string> tokens, StringBuilder builder) {
            if (builder.Length > 0) {
                tokens.Add(builder.ToString());
                builder.Clear();
            }
        }
    }
}
