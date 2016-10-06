using System;
using System.Collections.Generic;
using System.Xml;

namespace Generator {
    public class Patch {
        public List<PatchStruct> Structs { get; set; }
        public List<PatchCommand> Commands { get; set; }

        public Patch(XmlDocument doc) {
            Structs = new List<PatchStruct>();
            Commands = new List<PatchCommand>();

            XmlNode root = doc.ChildNodes[1];
            XmlNode structs = root.ChildNodes[0];

            for (int i = 0; i < structs.ChildNodes.Count; i++) {
                var s = new PatchStruct(structs.ChildNodes[i]);
                Structs.Add(s);
            }

            XmlNode commands = root.ChildNodes[1];

            for (int i = 0; i < commands.ChildNodes.Count; i++) {
                var c = new PatchCommand(commands.ChildNodes[i]);
                Commands.Add(c);
            }
        }
    }
}
