using System;
using System.IO;

using SpecReader;
namespace Generator {
    public class CPP_Offsets {
        public CPP_Offsets(Spec spec) {
            using (var writer = File.CreateText("../../../Offsets/offsets.cpp")) {
                Write(spec, writer);
            }
        }

        void Write(Spec spec, StreamWriter writer) {
            writer.WriteLine("#include<iostream>");
            writer.WriteLine("#include<vulkan/vulkan.h>");
            writer.WriteLine("#include<fstream>");
            writer.WriteLine();
            writer.WriteLine("int main() {");
            writer.WriteLine("    std::ofstream file;");
            writer.WriteLine("    file.open(\"offsets.txt\");");

            foreach (var s in spec.Structs) {
                if (s.Handle) continue;
                if (spec.ExtensionTypes.Contains(s.Name)) {
                    if (!spec.IncludedTypes.Contains(s.Name)) {
                        continue;
                    }
                }
                if (s.Name == "VkRect3D") continue; //defined in xml, but not in header
                writer.WriteLine("    file << \"{0}\" << std::endl;", s.Name);
                writer.WriteLine("    file << sizeof({0}) << std::endl;", s.Name);
                foreach (var f in s.Fields) {
                    writer.WriteLine("        file << \"    {0}: \" << offsetof({1}, {0}) << std::endl;", f.Name, s.Name);
                }
                writer.WriteLine("    file << std::endl;");
                writer.WriteLine();
            }

            writer.WriteLine("}");
        }
    }
}
