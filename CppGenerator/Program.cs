using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

using SpecReader;

namespace CppGenerator {
    class Program {
        static void Main(string[] args) {
            string output = "output";

            if (!Directory.Exists(output)) Directory.CreateDirectory(output);

            Spec spec;
            using (var reader = File.Open("vk.xml", FileMode.Open)) {
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                spec = new Spec(doc, 1, 0, null);
            }

            CppSpec cppSpec = new CppSpec(spec);
            Generator g = new Generator(cppSpec);
            g.WriteEnums(output);
        }
    }
}
