using System;
using System.Collections.Generic;
using System.Xml;

namespace CS_Generator {
    public class PatchCommand {
        public string Name { get; set; }
        public List<PatchParam> Params { get; set; }

        public PatchCommand(XmlNode root) {
            Name = root.Attributes["name"].Value;
            Params = new List<PatchParam>();

            foreach (XmlNode node in root.ChildNodes) {
                Params.Add(new PatchParam(node));
            }
        }

        public void Apply(CSCommand c) {
            foreach (var pp in Params) {
                foreach (var p in c.Params) {
                    if (pp.Name == p.Name) {
                        pp.Apply(p);
                    }
                }
            }
        }
    }

    public class PatchParam {
        public string Name { get; set; }
        public string Type { get; set; }

        public PatchParam(XmlNode root) {
            Name = root.Attributes["name"].Value;
            Type = root.Attributes["type"].Value;
        }

        public void Apply(CSParam p) {
            p.Type = Type;
        }
    }
}
