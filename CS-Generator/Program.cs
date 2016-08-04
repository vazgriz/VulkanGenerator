using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using VulkanGenerator;

namespace CS_Generator {
    class Program {
        static void Main(string[] args) {
            List<string> extensions = new List<string>{
                "VK_KHR_surface",
                "VK_KHR_swapchain",
                "VK_KHR_display",
                "VK_KHR_display_swapchain",
                "VK_KHR_win32_surface",
                "VK_EXT_debug_report",
            };
            string output = @"F:\Code\CSharpGameLibrary\CSharpGameLibrary\Vulkan";
            if (!Directory.Exists("output")) Directory.CreateDirectory("output");
            Spec spec;
            using (var reader = File.Open("vk.xml", FileMode.Open)) {
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                spec = new Spec(doc, 1, 0, extensions);
            }
            Generator g = new Generator(spec);
            g.WriteEnums(output, "CSGL.Vulkan");
            g.WriteCommands(output, "CSGL.Vulkan.Unmanaged");
            g.WriteStructs(output, "CSGL.Vulkan.Unmanaged");
            g.WriteLoader(output, "CSGL.Vulkan.Unmanaged");
        }
    }
}
