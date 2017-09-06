using System;
using System.Collections.Generic;

using SpecReader;

namespace Generator {
    public class CSStruct {
        public string Name { get; set; }
        public List<CSField> Fields { get; set; }
        public bool Unsafe { get; set; }
        public bool Union { get; set; }
        public bool Handle { get; set; }

        public CSStruct(Struct s) {
            Name = s.Name;
            Handle = s.Handle;
            Union = s.Union;

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
        public bool Unsafe { get; set; }
        public int Pointer { get; set; }
        public bool Fixed { get; set; }
        public int ArraySize { get; set; }

        public CSField(Field f) {
            Name = GetName(f.Name);
            Type = GetType(f.Type);
            if (Type.Contains("*")) Unsafe = true;
        }

        public string GetType(string type) {
            type = CSSpec.GetType(type);
            if (type.Contains("*")) return "IntPtr";
            if (type.Contains("PFN_")) return "IntPtr";
            return type;
        }

        string GetName(string name) {
            switch (name) {
                case "object": return "_object";
                default: return name;
            }
        }
    }
}
