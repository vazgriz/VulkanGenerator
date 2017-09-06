using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using SpecReader;

namespace Generator {
    class Program {
        static void Main(string[] args) {
            List<string> extensions = new List<string>{
                "VK_KHR_surface",
                "VK_KHR_swapchain",
                //"VK_KHR_display",
                //"VK_KHR_display_swapchain",
                //"VK_KHR_win32_surface",
                "VK_EXT_debug_report",
            };
            //string output = @"..\..\..\..\CSharpGameLibrary\CSharpGameLibrary\Vulkan";
            //string output2 = @"..\..\..\..\CSharpGameLibrary\CSharpGameLibrary\Vulkan\Unmanaged";
            string output = "output";

            Offsets offsets;
            using (var stream = File.Open("offsets.txt", FileMode.Open)) {
                offsets = new Offsets(stream);
            }

            if (!Directory.Exists(output)) Directory.CreateDirectory(output);
            Spec spec;
            Patch patch;
            using (var reader = File.Open("vk.xml", FileMode.Open)) {
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                spec = new Spec(doc, 1, 0, extensions);
            }

            //CPP_Offsets cpp = new CPP_Offsets(spec);
            //CS_Offsets cs = new CS_Offsets(spec, output);

            using (var reader = File.Open("patch.xml", FileMode.Open)) {
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                patch = new Patch(doc);
            }
            CSSpec csSpec = new CSSpec(spec, patch);
            Generator g = new Generator(csSpec, offsets);
            g.WriteEnums(output, "CSGL.Vulkan");
            g.WriteDelegates(output, "CSGL.Vulkan.Unmanaged");
            g.WriteCommands(output, "CSGL.Vulkan.Unmanaged");
            g.WriteStructs(output, "CSGL.Vulkan");
            //g.WriteLoader(output, "CSGL.Vulkan.Unmanaged");
            //g.WriteFunctionNames(output);
        }
    }
}
