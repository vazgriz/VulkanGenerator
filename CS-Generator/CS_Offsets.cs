using System;
using System.IO;

using SpecReader;
namespace Generator {
    public class CS_Offsets {
        public CS_Offsets(Spec spec, string path) {
            using (var writer = File.CreateText(path + "/offsets.cs")) {
                Write(spec, writer);
            }
        }

        void Write(Spec spec, StreamWriter writer) {
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using CSGL.Vulkan;");
            writer.WriteLine();
            writer.WriteLine("public static class Offset {");
            writer.WriteLine("    public static void Offsets(){");

            foreach (var s in spec.Structs) {
                if (s.Handle) continue;
                if (spec.ExtensionTypes.Contains(s.Name)) {
                    if (!spec.IncludedTypes.Contains(s.Name)) {
                        continue;
                    }
                }
                writer.WriteLine("        Console.WriteLine(\"{0}\");", s.Name);
                foreach (var f in s.Fields) {
                    writer.WriteLine("            Console.WriteLine(\"    {0}: {{0}}\", Marshal.OffsetOf<{1}>(\"{0}\"));", f.Name, s.Name);
                }
                writer.WriteLine("        Console.WriteLine();");
                writer.WriteLine();
            }
            writer.WriteLine("    }");
            writer.WriteLine("}");
        }
    }
}
