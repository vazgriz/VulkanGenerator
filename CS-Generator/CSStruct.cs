using System;
using System.Collections.Generic;

using VulkanGenerator;

namespace CS_Generator {
    public class CSStruct {
        public string Name { get; set; }
        public List<CSField> Fields { get; set; }
        public bool Unsafe { get; set; }
        public bool Union { get; set; }

        public CSStruct(Struct s) {
            Name = s.Name;

            Fields = new List<CSField>();

            foreach (var f in s.Fields) {
                var csf = new CSField(f);
                Fields.Add(csf);
                if (csf.Unsafe) Unsafe = true;
            }
        }
    }

    public class CSField {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Attribute { get; set; }
        public bool Unsafe { get; set; }
        public int Pointer { get; set; }
        public bool Fixed { get; set; }

        public CSField(Field f) {
            Name = GetName(f.Name);
            Type = GetType(f.Type);
            if (Type.Contains("*")) Unsafe = true;
        }

        public string GetType(string type) {
            if (type == "void*") return "IntPtr";
            return CSSpec.GetType(type);
        }

        string GetName(string name) {
            switch (name) {
                case "object": return "_object";
                default: return name;
            }
        }
    }
}
