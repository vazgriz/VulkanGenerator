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
            HashSet<string> enumNames = Split(enumName);
            string[] tokens = name.Split('_');
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++) {
                var token = tokens[i];
                if (token == "VK") continue;
                if (enumNames.Contains(token)) {
                    enumNames.Remove(token);
                    continue;
                }
                if (char.IsDigit(token[0])) builder.Append('_');
                builder.Append(token[0]);   //capitalize first letter
                for (int j = 1; j < token.Length; j++) {
                    builder.Append(char.ToLower(token[j])); //lowercase every other letter
                }
            }

            return builder.ToString();
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
