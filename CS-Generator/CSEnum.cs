using System;
using System.Collections.Generic;
using System.Text;

using VulkanGenerator;

namespace CS_Generator {
    public class CSEnum {
        public string Name { get; set; }
        public List<CSEnumValue> Values { get; set; }
        public bool Flags { get; set; }

        public CSEnum(VulkanGenerator.Enum e) {
            Name = e.Name;
            Flags = e.Bitmask;
            Values = new List<CSEnumValue>();

            foreach (var v in e.Values) {
                string name = v.Name;
                string value;
                if (v.Bitpos) {
                    value = ((int)Math.Pow(2, int.Parse(v.Value))).ToString();
                } else {
                    value = v.Value;
                }
                Values.Add(new CSEnumValue(name, value));
            }
        }
    }

    public class CSEnumValue {
        public string Name { get; set; }
        public string Value { get; set; }

        public CSEnumValue(string name, string value) {
            Name = GetName(name);
            Value = value;
        }

        public string GetName(string name) {
            string[] tokens = name.Split('_');
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++) {
                var token = tokens[i];
                if (token == "VK") continue;
                if (char.IsDigit(token[0]) && i == 0) builder.Append('_');
                builder.Append(token[0]);
                for (int j = 1; j < token.Length; j++) {
                    builder.Append(char.ToLower(token[j]));
                }
            }

            return builder.ToString();
        }
    }
}
