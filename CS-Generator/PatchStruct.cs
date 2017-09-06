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
        public string ArraySize { get; set; }

        public PatchField(XmlNode node) {
            Name = node.Attributes["name"].Value;
            Type = node.Attributes["type"].Value;
            ArraySize = node.Attributes["array-size"]?.Value;
        }

        public void Apply(CSField f) {
            f.Type = Type;
            if (ArraySize != null) {
                f.ArraySize = int.Parse(ArraySize);
            }
        }
    }
}
