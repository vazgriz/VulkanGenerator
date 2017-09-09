using System;
using System.Collections.Generic;
using System.Text;

using SpecReader;

namespace Generator {
    public class CSEnum {
        public string Name { get; set; }
        public List<CSEnumValue> Values { get; set; }
        public bool Flags { get; set; }

        public CSEnum(SpecReader.Enum e) {
            Name = e.Name;
            Flags = e.Bitmask;
            Values = new List<CSEnumValue>();

            foreach (var v in e.Values) {
                string vName = v.Name;
                string value;
                if (v.Bitpos) {
                    value = ((int)Math.Pow(2, int.Parse(v.Value))).ToString();
                } else {
                    value = v.Value;
                }
                Values.Add(new CSEnumValue(Name, vName, value));
            }
        }
    }

    public class CSEnumValue {
        public string Name { get; set; }
        public string Value { get; set; }

        public CSEnumValue(string enumName, string name, string value) {
            Name = GetName(enumName, name);
            Value = value;
        }

        public string GetName(string enumName, string name) {
            HashSet<string> enumNames = Split(enumName);    //get name of enum (eg VkStructureType)
            string[] tokens = name.Split('_');
            StringBuilder builder = new StringBuilder();

            bool underscoreLast = false;
            int emitted = 0;

            for (int i = 0; i < tokens.Length; i++) {
                var token = tokens[i];
                if (token == "VK") continue;
                if (enumNames.Contains(token)) {    //strip name of enum from enum value (eg STRUCTURE_TYPE_INSTANCE_CREATE_INFO -> INSTANCE_CREATE_INFO)
                    enumNames.Remove(token);
                    continue;
                }
                EmitValue(builder, token, emitted == 0, i, tokens.Length, ref underscoreLast);
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

            for (int i = 0; i < enumName.Length; i++) {
                char c = enumName[i];
                if (char.IsUpper(c)) {
                    Emit(tokens, builder);
                }

                builder.Append(char.ToUpper(c));
            }

            Emit(tokens, builder);

            return new HashSet<string>(tokens);
        }

        void Emit(List<string> tokens, StringBuilder builder) {
            if (builder.Length > 0) {
                tokens.Add(builder.ToString());
                builder.Clear();
            }
        }
    }
}
