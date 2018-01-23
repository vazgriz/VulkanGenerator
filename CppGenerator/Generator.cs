using System;
using System.IO;

using SpecReader;

namespace CppGenerator {
    public class Generator {
        DateTime time;
        Spec spec;

        public Generator(Spec spec) {
            this.spec = spec;
            time = DateTime.Now;
        }

        public void WriteEnums(string path) {
            path = Path.Combine(path, "enums.h");

            using (var writer = File.CreateText(path)) {
                writer.WriteLine("//auto generated on {0}", time.ToString());

                foreach (var name in spec.EnumMap.Keys) {
                    writer.WriteLine("enum class {0} {{", name);

                    var e = spec.EnumMap[name];

                    foreach (var value in e.Values) {
                        writer.WriteLine("    {0},", value.Name);
                    }

                    writer.WriteLine("};\n");
                }
            }
        }
    }
}
