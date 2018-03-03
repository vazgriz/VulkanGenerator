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
                    writer.WriteLine("    enum class {0} {{", e.Name);

                    foreach (var v in e.Values) {
                        writer.WriteLine("        {0} = {1},", v.Name, v.Value);
                    }

                    writer.WriteLine("    };\r\n");

                    if (e.Bitmask) {
                        writer.WriteLine("    inline {0} operator | ({0} a, {0} b) {{", e.Name);
                        writer.WriteLine("        return static_cast<{0}>(static_cast<int>(a) | static_cast<int>(b));", e.Name);
                        writer.WriteLine("    }");
                        writer.WriteLine();
                        writer.WriteLine("    inline {0}& operator |= ({0}& a, {0}& b) {{", e.Name);
                        writer.WriteLine("        a = static_cast<{0}>(static_cast<int>(a) | static_cast<int>(b));", e.Name);
                        writer.WriteLine("        return a;");
                        writer.WriteLine("    }\r\n");
                    }
                }

                writer.WriteLine("}");
            }
        }
    }
}
