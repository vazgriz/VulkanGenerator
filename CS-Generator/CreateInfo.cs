using System;
using System.Collections.Generic;

using VulkanGenerator;

namespace CS_Generator {
    public class CreateInfo {
        public string Name { get; set; }
        public List<Property> Properties { get; set; }

        public CreateInfo(Struct s) {
            Name = s.Name.Substring(2);
            Properties = new List<Property>(s.Fields.Count);

            for (int i = 0; i < s.Fields.Count; i++) {
                var f = s.Fields[i];
                if (f.Name == "sType" || f.Name == "pNext") continue;
                Properties.Add(new Property(f));
            }
        }
    }
}
