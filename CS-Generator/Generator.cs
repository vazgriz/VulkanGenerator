using System;
using System.IO;
using System.Text;

using VulkanGenerator;

namespace CS_Generator {
    public class Generator {
        Spec spec;
        public Generator(Spec spec) {
            this.spec = spec;
            Console.WriteLine("{0} enums, {1} included", spec.Enums.Count, spec.IncludedEnums.Count);
            Console.WriteLine("{0} commands, {1} included", spec.Commands.Count, spec.IncludedCommands.Count);
            Console.WriteLine("{0} structs, {1} included", spec.Structs.Count, spec.IncludedTypes.Count);

            Preprocess();
        }

        void Preprocess() {
            foreach (var e in spec.Enums) {
                var rName = e.Name;
                var nName = GetName(e);
                if (spec.AllEnums.Contains(rName) && spec.AllEnums.Contains(nName) && rName != nName) {
                    var flagEnum = spec.EnumMap[nName];
                    flagEnum.Values = e.Values;
                    spec.AllEnums.Remove(rName);
                }
            }
        }

        public void WriteEnums(string outputFolder, string _namespace) {
            string path = Path.Combine(outputFolder, "enums.cs");
            using (var writer = File.CreateText(path)) {
                writer.WriteLine("using System;");
                writer.WriteLine();
                writer.WriteLine("namespace {0} {{", _namespace);

                foreach (var e in spec.Enums) {
                    if (!spec.AllEnums.Contains(e.Name)) continue;
                    writer.WriteLine("    public enum {0} {{", GetName(e));

                    foreach (var v in e.Values) {
                        writer.WriteLine("        {0} = {1},", GetName(v), v.Value);
                    }

                    writer.WriteLine("    }");
                    writer.WriteLine();
                }

                writer.WriteLine("}");
            }
        }

        public void WriteCommands(string outputFolder, string _namespace) {
            string path = Path.Combine(outputFolder, "commands.cs");
            using (var writer = File.CreateText(path)) {
                writer.WriteLine("using System;");
                writer.WriteLine();
                writer.WriteLine("namespace {0} {{", _namespace);
                writer.WriteLine("    public static partial class VK {");

                foreach (var c in spec.Commands) {
                    if (!spec.IncludedCommands.Contains(c.Name)) continue;

                    string _unsafe = "";
                    foreach (var p in c.Params) {
                        if (p.Pointer) {
                            _unsafe = " unsafe";
                        }
                    }

                    writer.Write("        public{0} delegate {1} {2}Delegate(", _unsafe, GetType(c), c.Name);

                    for (int i = 0; i < c.Params.Count; i++) {
                        var p = c.Params[i];
                        writer.Write("{0} {1}", GetType(p), GetName(p));
                        if (i < c.Params.Count - 1) writer.Write(", ");
                    }

                    writer.WriteLine(");");
                    writer.WriteLine("        public static{0} {1}Delegate {1};", "", c.Name);
                    writer.WriteLine();
                }

                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }

        public void WriteStructs(string outputFolder, string _namespace) {
            string path = Path.Combine(outputFolder, "structs.cs");
            using (var writer = File.CreateText(path)) {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Runtime.InteropServices;");
                writer.WriteLine();
                writer.WriteLine("namespace {0} {{", _namespace);

                foreach (var s in spec.Structs) {
                    if (spec.ExtensionTypes.Contains(s.Name) && !spec.IncludedTypes.Contains(s.Name)) continue;
                    string _unsafe = "";
                    foreach (var f in s.Fields) {
                        if (f.Pointer) {
                            _unsafe = " unsafe";
                            break;
                        }
                    }

                    writer.WriteLine("    public{0} struct {1} {{", _unsafe, s.Name);
                    foreach (var f in s.Fields) {
                        string fUnsafe = "";
                        if (f.Pointer) fUnsafe = _unsafe;
                        writer.WriteLine("        public{0} {1} {2};", fUnsafe, GetType(f), GetName(f));
                    }
                    writer.WriteLine("    }");
                    writer.WriteLine();
                }
                
                writer.WriteLine("}");
            }
        }

        public void WriteLoader(string outputFolder, string _namespace) {
            string path = Path.Combine(outputFolder, "loader.cs");
            using (var writer = File.CreateText(path)) {
                writer.WriteLine("using System;");
                writer.WriteLine();
                writer.WriteLine("namespace {0} {{", _namespace);
                writer.WriteLine("    public static partial class VK {");

                writer.WriteLine("        static readonly string[] commands = {");
                foreach (var c in spec.Commands) {
                    if (!spec.IncludedCommands.Contains(c.Name)) continue;
                    writer.WriteLine("            \"{0}\",", c.Name);
                }
                writer.WriteLine("        };");

                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }

        string GetName(VulkanGenerator.Enum e) {
            return BitsToFlag(e.Name);
        }

        string GetName(EnumValue e) {
            string[] tokens = e.Name.Split('_');
            StringBuilder builder = new StringBuilder();
            int parts = 0;
            for (int i = 0; i < tokens.Length; i++) {
                var t = tokens[i];
                if (t == "VK") continue;

                if (parts == 0 && char.IsDigit(t[0])) builder.Append('_');

                builder.Append(char.ToUpper(t[0]));
                for (int j = 1; j < t.Length; j++) {
                    builder.Append(char.ToLower(t[j]));
                }
                parts++;
            }

            return builder.ToString();
        }

        string GetType(Field field) {
            string result = BitsToFlag(field.Type);

            if (result.Contains("PFN_")) {
                result = "IntPtr";
            }
            switch (result) {
                case "size_t": return "long";
                case "VkBool32": return "uint";
                case "VkDeviceSize": return "ulong";
                case "VkSampleMask": return "uint";

                case "uint8_t": return "byte";
                case "uint16_t": return "ushort";
                case "uint32_t": return "uint";
                case "uint64_t": return "ulong";

                case "int8_t": return "sbyte";
                case "int16_t": return "short";
                case "int32_t": return "int";
                case "int64_t": return "long";

                case "char*": return "byte*";
                case "char**": return "byte**";
                case "uint32_t*": return "uint*";
                case "VkSampleMask*": return "uint*";

                case "HWND": return "IntPtr";
                case "HINSTANCE": return "IntPtr";
                default: return result;
            }
        }

        string GetName(Field field) {
            switch (field.Name) {
                case "object": return "_object";
                default: return field.Name;
            }
        }

        string GetType(Command c) {
            return GetType(c.ReturnType);
        }

        string GetType(Param p) {
            return GetType(BitsToFlag(p.Type));
        }

        string GetName(Param p) {
            switch (p.Name) {
                case "event": return "_event";
                case "object": return "_object";
                default: return p.Name;
            }
        }

        string GetType(string input) {
            switch (input) {
                case "size_t": return "long";
                case "VkBool32": return "uint";
                case "VkDeviceSize": return "ulong";
                case "VkSampleMask": return "uint";
                case "PFN_vkVoidFunction": return "IntPtr";

                case "uint8_t": return "byte";
                case "uint16_t": return "ushort";
                case "uint32_t": return "uint";
                case "uint64_t": return "ulong";

                case "int8_t": return "sbyte";
                case "int16_t": return "short";
                case "int32_t": return "int";
                case "int64_t": return "long";

                case "char*": return "byte*";
                case "char**": return "byte**";
                case "uint32_t*": return "uint*";
                case "VkSampleMask*": return "uint*";
                case "VkBool32*": return "uint*";
                case "VkDeviceSize*": return "ulong*";
                case "size_t*": return "ulong*";

                case "HWND": return "IntPtr";
                case "HINSTANCE": return "IntPtr";
                default: return input;
            }
        }

        string BitsToFlag(string input) {
            string result = input;
            const string check = "FlagBits";
            if (input.Contains(check)) {
                int i = input.IndexOf(check);
                result = input.Substring(0, i) + "Flags";
            }
            return result;
        }
    }
}
