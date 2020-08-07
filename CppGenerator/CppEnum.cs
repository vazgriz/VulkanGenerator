using System;
using System.Text;
using System.Collections.Generic;

using SpecReader;

namespace CppGenerator {
    public class CppEnum {
        public List<CppEnumValue> Values { get; private set; }

        public string OriginalName { get; private set; }
        public string Name { get; private set; }
        public bool Bitmask { get; private set; }

        public CppEnum(Spec spec, SpecReader.Enum e, List<string> suffixes, Dictionary<string, int> map) {
            OriginalName = FixName(e.Name);
            Name = StripSuffix(OriginalName, suffixes, map).Substring(2);

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
                    Values.Add(new CppEnumValue("None", "0"));
                }
            }

            foreach (var v in e.Values) {
                Values.Add(new CppEnumValue(spec, e, v));
            }

            Bitmask = e.Bitmask;
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

        string StripSuffix(string name, List<string> suffixes, Dictionary<string, int> map) {
            foreach (var suffix in suffixes) {
                int index = name.IndexOf(suffix);

                if (index != -1) {
                    string newName = name.Substring(0, index);

                    if (map.TryGetValue(newName, out int value)) {
                        if (value == 1) {
                            return newName;
                        }
                    }
                }
            }

            return name;
        }
    }

    public class CppEnumValue {
        public string Name { get; private set; }
        public string Value { get; private set; }

        Spec spec;

        public CppEnumValue(Spec spec, SpecReader.Enum e, EnumValue v) {
            this.spec = spec;

            Name = GetName(e, v);
            string value;
            if (v.Bitpos) {
                value = ((int)Math.Pow(2, int.Parse(v.Value))).ToString();
            } else {
                value = v.Value;
            }
            Value = value;
        }

        public CppEnumValue(string name, string value) {
            Name = name;
            Value = value;
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
            //except if token contains numbers or is a suffix

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

            if (index == count - 1 && spec.Suffixes.Contains(token)) {
                builder.Append(token);  //if token is a suffix (eg KHR), preserve casing
            } else {
                bool letterLast = false;

                foreach (var c in token) {
                    if (char.IsLetter(c)) {
                        if (letterLast) {
                            builder.Append(char.ToLower(c));
                        } else {
                            builder.Append(c);
                            letterLast = true;
                        }
                    } else {
                        builder.Append(c);
                        letterLast = false;
                    }
                }
            }

            if (hasNumbers) {
                if (index != count - 1) builder.Append("_");
            }

            underscoreLast = hasNumbers;
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
