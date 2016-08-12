using System;
using System.Collections.Generic;
using System.Xml;

namespace CS_Generator {
    public class Patch {
        public List<PatchStruct> Structs { get; set; }
        public List<string> PreserveTypes { get; set; }

        public Patch(XmlDocument doc) {
            Structs = new List<PatchStruct>();
            PreserveTypes = new List<string>();

            XmlNode root = doc.ChildNodes[1];
            XmlNode structs = root.ChildNodes[0];

            for (int i = 0; i < structs.ChildNodes.Count; i++) {
                var s = new PatchStruct(structs.ChildNodes[i]);
                Structs.Add(s);
            }

            XmlNode commands = root.ChildNodes[1];

            for (int i = 0; i < commands.ChildNodes.Count; i++) {
                XmlNode node = commands.ChildNodes[i];
                if (node.Name == "params") {
                    foreach (XmlNode param in node.ChildNodes) {
                        if (param.Name == "preserve") {
                            PreserveTypes.Add(param.Attributes["type"].Value);
                        }
                    }
                } else if (node.Name == "command") {

                }
            }
        }
    }
}
