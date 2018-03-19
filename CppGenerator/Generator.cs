using System;
using System.IO;

using SpecReader;

namespace CppGenerator {
    public class Generator {
        DateTime time;
        CppSpec spec;

        public Generator(CppSpec spec) {
            this.spec = spec;
            time = DateTime.Now;
        }

        public void WriteEnums(string path) {
            path = Path.Combine(path, "enums.h");

            using (var writer = File.CreateText(path)) {
                writer.WriteLine("//auto generated on {0}", time.ToString());
                writer.WriteLine("#pragma once");
                writer.WriteLine();

                writer.WriteLine("namespace vk {");
                
                foreach (var e in spec.Enums) {
                    string name = e.Name;
                    if (spec.SuffixNameMap.TryGetValue(name, out int count)) {
                        if (count != 1) {
                            name = e.OriginalName;
                        }
                    }

                    if (e.Bitmask) {
                        writer.WriteLine("    enum class {0} : uint32_t {{", name);
                    } else {
                        writer.WriteLine("    enum class {0} {{", name);
                    }

                    foreach (var v in e.Values) {
                        writer.WriteLine("        {0} = {1},", v.Name, v.Value);
                    }

                    writer.WriteLine("    };\r\n");

                    if (e.Bitmask) {
                        writer.WriteLine("    inline {0} operator | ({0} a, {0} b) {{", name);
                        writer.WriteLine("        return static_cast<{0}>(static_cast<int>(a) | static_cast<int>(b));", name);
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline {0}& operator |= ({0}& a, {0} b) {{", name);
                        writer.WriteLine("        a = static_cast<{0}>(static_cast<int>(a) | static_cast<int>(b));", name);
                        writer.WriteLine("        return a;");
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline {0} operator & ({0} a, {0} b) {{", name);
                        writer.WriteLine("        return static_cast<{0}>(static_cast<int>(a) & static_cast<int>(b));", name);
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline {0}& operator &= ({0}& a, {0}& b) {{", name);
                        writer.WriteLine("        a = static_cast<{0}>(static_cast<int>(a) & static_cast<int>(b));", name);
                        writer.WriteLine("        return a;");
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline bool operator == ({0}& a, {0}& b) {{", name);
                        writer.WriteLine("        return static_cast<int>(a) == static_cast<int>(b);");
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline bool operator != ({0}& a, {0}& b) {{", name);
                        writer.WriteLine("        return static_cast<int>(a) != static_cast<int>(b);");
                        writer.WriteLine("    }");
                        writer.WriteLine();
                    }
                }

                writer.WriteLine("}");
                writer.WriteLine();
                writer.WriteLine("static_assert(sizeof(VkResult) == sizeof(vk::Result), \"Enums are not the same size\");");
            }
        }
    }
}
