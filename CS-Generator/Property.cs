using System;

using VulkanGenerator;

namespace CS_Generator {
    public class Property {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Array { get; set; }
        public string UnderlyingType { get; set; }
        public string BackingName { get; set; }

        public Property(Field field) {
            Name = GetName(field);
            Type = GetType(field.Type);
        }

        string GetType(string input) {
            if (input == "char**")return "string[]";
            if (input == "void*") return "IntPtr";

            if (input.Contains("*")) {
                string underType = input.Substring(0, input.Length - 1);
                UnderlyingType = GetType(underType);
                Array = true;
                return UnderlyingType + "[]";
            }

            return CSSpec.GetType(input);
        }

        string GetName(Field field) {
            string input = field.Name;
            if (field.Type.Contains("*")) while (input[0] == 'p') input = input.Substring(1);
            BackingName = char.ToLower(input[0]) + input.Substring(1);
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
