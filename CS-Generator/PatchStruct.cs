using System;
using System.Collections.Generic;
using System.Xml;

namespace Generator {
    public class PatchStruct {
        public string Name { get; set; }
        public List<PatchField> Fields { get; set; }

        public PatchStruct(XmlNode node) {
            Fields = new List<PatchField>();

            Name = node.Attributes["name"].Value;

            for (int i = 0; i < node.ChildNodes.Count; i++) {
                var f = new PatchField(node.ChildNodes[i]);
                Fields.Add(f);
            }
        }

        public void Apply(CSStruct s) {
            foreach (var pf in Fields) {
                foreach (var f in s.Fields) {
                    if (f.Name == pf.Name) {
                        pf.Apply(f);
                    }
                }
            }
        }
    }

    public class PatchField {
        public string Name { get; set; }
        public string Type { get; set; }
        public string MarshalType { get; set; }
        public string MarshalSize { get; set; }

        public PatchField(XmlNode node) {
            Name = node.Attributes["name"].Value;
            Type = node.Attributes["type"].Value;
            MarshalType = node.Attributes["marshal-type"]?.Value;
            MarshalSize = node.Attributes["marshal-size"]?.Value;
        }

        public void Apply(CSField f) {
            f.Type = Type;
            if (MarshalType != null) {
                if (MarshalSize == null) {
                    var att = string.Format("[MarshalAs(UnmanagedType.{0})]", MarshalType);
                    f.Attribute = att;
                } else {
                    f.ArraySize = int.Parse(MarshalSize);
                }
            }
        }
    }
}
