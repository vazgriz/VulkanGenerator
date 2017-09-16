using System;
using System.Collections.Generic;

using SpecReader;

namespace Generator {
    public class CSSpec {
        public List<CSStruct> Structs { get; set; }
        public List<CSEnum> Enums { get; set; }
        public List<CSCommand> Commands { get; set; }
        public Dictionary<string, string> FlagsMap { get; set; }

        Dictionary<string, CSEnum> EnumMap { get; set; }

        public CSSpec(Spec spec, Patch patch) {
            Structs = new List<CSStruct>();
            Enums = new List<CSEnum>();
            Commands = new List<CSCommand>();
            EnumMap = new Dictionary<string, CSEnum>();
            FlagsMap = new Dictionary<string, string>();

            foreach (var s in spec.Structs) {
                if (spec.ExtensionTypes.Contains(s.Name) && !spec.IncludedTypes.Contains(s.Name)) continue;
                var css = new CSStruct(s);
                Structs.Add(css);
            }

            foreach (var e in spec.Enums) {
                if (spec.ExtensionTypes.Contains(e.Name) && !spec.IncludedTypes.Contains(e.Name)) continue;
                var cse = new CSEnum(e);
                if (cse.Name.Contains("Flags")) cse.Values.Add(new CSEnumValue(cse.Name, "None", "0"));
                Enums.Add(cse);
                EnumMap.Add(cse.Name, cse);
            }

            foreach (var c in spec.Commands) {
                if (!spec.IncludedCommands.Contains(c.Name)) continue;
                var csc = new CSCommand(spec, c);
                Commands.Add(csc);
            }

            foreach (var s in Structs) {
                foreach (var ps in patch.Structs) {
                    if (ps.Name == s.Name) {
                        ps.Apply(s);
                    }
                }
            }

            foreach (var c in Commands) {
                foreach (var pc in patch.Commands) {
                    if (pc.Name == c.Name) {
                        pc.Apply(c);
                    }
                }
            }

            FixEnums();
        }

        public void FixEnums() {
            for (int i = Enums.Count - 1; i >= 0; i--) {
                var e = Enums[i];
                if (!e.Name.Contains("FlagBits")) continue;

                int index = e.Name.IndexOf("FlagBits");
                string flagNames = e.Name.Substring(0, index);
                flagNames += "Flags";
                if (e.Name.Length > index + 8) flagNames += e.Name.Substring(index + 8, e.Name.Length - (index + 8));
                var flags = EnumMap[flagNames];
                foreach (var v in e.Values) {
                    flags.Values.Add(v);
                }
                Enums.RemoveAt(i);
                FlagsMap.Add(e.Name, flags.Name);
            }
        }

        public static string GetType(string input) {
            switch (input) {
                case "size_t": return "IntPtr";
                case "VkBool32": return "uint";
                case "VkDeviceSize": return "ulong";
                case "VkSampleMask": return "uint";
                case "PFN_vkVoidFunction": return "IntPtr";

                case "uint8_t": return "byte";
                case "uint16_t": return "ushort";
                case "uint32_t": return "uint";
                case "uint64_t": return "ulong";
                case "char": return "byte";

                case "int8_t": return "sbyte";
                case "int16_t": return "short";
                case "int32_t": return "int";
                case "int64_t": return "long";

                case "uint8_t*": return "byte*";
                case "uint16_t*": return "ushort*";
                case "uint32_t*": return "uint*";
                case "uint64_t*": return "ulong*";

                case "int8_t*": return "sbyte*";
                case "int16_t*": return "short*";
                case "int32_t*": return "int*";
                case "int64_t*": return "long*";

                case "char*": return "IntPtr";
                case "char**": return "IntPtr";
                case "VkSampleMask*": return "uint*";
                case "VkBool32*": return "uint*";
                case "VkDeviceSize*": return "ulong*";
                case "size_t*": return "IntPtr*";
                    
                default: return input;
            }
        }

        public static bool IsPrimitive(string input) {
            if (input == "byte" ||
                input == "ushort" ||
                input == "uint" ||
                input == "ulong" ||
                input == "sbyte" ||
                input == "short" ||
                input == "int" ||
                input == "long" ||
                input == "float" ||
                input == "double") {
                return true;
            }
            return false;
        }

        public static int GetSize(string input) {
            switch (input) {
                case "byte": return 1;
                case "int": return 4;
                case "float": return 4;
                case "uint": return 4;
                case "long": return 8;
                case "ulong": return 8;
                default: return -1;
            }
        }
    }
}
