using System;
using System.Collections.Generic;
using System.Xml;

namespace VulkanGenerator {
    public class Spec {
        int major;
        int minor;
        List<string> requestedExtensions;

        public List<Enum> Enums { get; private set; }
        public HashSet<string> AllEnums { get; private set; }
        public List<Command> Commands { get; private set; }
        public List<Struct> Structs { get; private set; }
        public HashSet<string> IncludedEnums { get; private set; }
        public HashSet<string> IncludedCommands { get; private set; }
        public HashSet<string> IncludedTypes { get; private set; }
        public HashSet<string> ExtensionTypes { get; private set; }

        public Dictionary<string, Enum> EnumMap { get; private set; }

        public Spec(XmlDocument doc, int major, int minor, List<string> extensions) {
            this.major = major;
            this.minor = minor;
            requestedExtensions = extensions;

            Enums = new List<Enum>();
            AllEnums = new HashSet<string>();
            Commands = new List<Command>();
            Structs = new List<Struct>();
            IncludedEnums = new HashSet<string>();
            IncludedCommands = new HashSet<string>();
            IncludedTypes = new HashSet<string>();
            ExtensionTypes = new HashSet<string>();

            EnumMap = new Dictionary<string, Enum>();

            Load(doc);
        }

        void Load(XmlDocument doc) {
            var root = doc.ChildNodes[1];
            for (int i = 0; i < root.ChildNodes.Count; i++) {
                var node = root.ChildNodes[i];
                if (node is XmlComment) continue;
                if (node.Name == "types") {
                    LoadTypes(node);
                } else if (node.Name == "enums") {
                    LoadEnums(node);
                } else if (node.Name == "feature") {
                    ResolveFeatures(node);
                } else if (node.Name == "commands") {
                    LoadCommands(node);
                } else if (node.Name == "extensions") {
                    ResolveExtensions(node);
                }
            }
        }

        void LoadTypes(XmlNode root) {
            foreach (XmlNode node in root.ChildNodes) {
                if (node is XmlComment) continue;
                if (node.Attributes["requires"] != null && node.ChildNodes.Count == 0) {
                }
                if (node.Attributes["category"] != null) {
                    string cat = node.Attributes["category"].Value;
                    if (cat == "union" || cat == "struct") {
                        string name = node.Attributes["name"].Value;
                        bool union = cat == "union";
                        List<Field> fields = new List<Field>();

                        foreach (XmlNode fNode in node.ChildNodes) {
                            if (fNode is XmlComment) continue;
                            if (fNode.Name == "validity") continue;
                            LoadField(fNode, fields);
                        }

                        var s = new Struct(name, fields, union);
                        Structs.Add(s);
                    } else if (cat == "handle") {
                        string name = node["name"].InnerText;
                        List<Field> fields = new List<Field>();
                        fields.Add(new Field("native", "IntPtr", false));
                        var s = new Struct(name, fields, false);
                        Structs.Add(s);
                    } else if (cat == "enum") {
                        var eName = node.Attributes["name"].Value;
                        if (!EnumMap.ContainsKey(eName)) {
                            var e = new Enum(eName, false);
                            EnumMap.Add(eName, e);
                            Enums.Add(e);
                            AllEnums.Add(eName);
                        }
                    } else if (cat == "bitmask") {
                        var eName = node["name"].InnerText;
                        if (!EnumMap.ContainsKey(eName)) {
                            var e = new Enum(eName, true);
                            EnumMap.Add(eName, e);
                            Enums.Add(e);
                            AllEnums.Add(eName);
                        }
                    }
                }
            }
        }

        void LoadField(XmlNode root, List<Field> fields) {
            string name = null;
            string type = null;
            bool pointer = false;

            foreach (XmlNode node in root.ChildNodes) {
                if (node.Name == "name") name = node.InnerText;
                if (node.Name == "type") type = node.InnerText;
            }

            foreach (char c in root.InnerText) {
                if (c == '*') {
                    type += c;
                    pointer = true;
                }
            }

            fields.Add(new Field(name, type, pointer));
        }

        void LoadEnums(XmlNode root) {
            string name = root.Attributes["name"].Value;

            if (name == "API Constants") return;
            List<EnumValue> values = new List<EnumValue>();
            foreach (XmlNode node in root.ChildNodes) {
                if (node is XmlComment) continue;
                if (node.Name != "enum") continue;
                string vName = node.Attributes["name"].Value;
                var att = node.Attributes["value"] ?? node.Attributes["bitpos"];
                string value = att.Value;
                var v = new EnumValue(vName, value);
                values.Add(v);
            }
            bool bitmask = root.Attributes["type"].Value == "bitmask";
            var e = EnumMap[name];
            e.Bitmask = bitmask;
            e.Values = values;
        }

        void LoadCommands(XmlNode root) {
            foreach (XmlNode node in root.ChildNodes) {
                if (node is XmlComment) continue;
                LoadCommand(node);
            }
        }

        void LoadCommand(XmlNode root) {
            string returnType = root["proto"]["type"].InnerText;
            string name = root["proto"]["name"].InnerText;
            List<Param> ps = new List<Param>();

            foreach (XmlNode node in root.ChildNodes) {
                if (node.Name == "param") {
                    ps.Add(LoadParam(node));
                }
            }

            var c = new Command(name, returnType);
            Commands.Add(c);
            c.Params = ps;
        }

        Param LoadParam(XmlNode root) {
            string name = root["name"].InnerText;
            string type = root["type"].InnerText;
            bool pointer = false;

            foreach (char c in root.InnerText) {
                if (c == '*') {
                    type += c;
                    pointer = true;
                }
            }

            return new Param(name, type, pointer);
        }

        void ResolveFeatures(XmlNode root) {
            string number = root.Attributes["number"].Value;
            string[] tokens = number.Split('.');
            int fMajor = int.Parse(tokens[0]);
            int fMinor = int.Parse(tokens[1]);
            if ((fMajor < major) || (fMajor == major && fMinor < minor)) return;
            foreach (XmlNode node in root.ChildNodes) {
                if (node.Name == "require") {
                    foreach (XmlNode f in node.ChildNodes) {
                        if (f.Name == "enum") {
                            IncludedEnums.Add(f.Attributes["name"].Value);
                        } else if (f.Name == "command") {
                            IncludedCommands.Add(f.Attributes["name"].Value);
                        }
                    }
                }
            }
        }

        void ResolveExtensions(XmlNode root) {
            foreach (XmlNode extension in root.ChildNodes) {
                if (extension is XmlComment) continue;
                string eName = extension.Attributes["name"].Value;

                foreach (XmlNode r in extension.ChildNodes) {
                    foreach (XmlNode node in r.ChildNodes) {
                        if (r.Name == "require") {
                            if (node.Name == "command") {
                                if (requestedExtensions.Contains(eName)) {
                                    IncludedCommands.Add(node.Attributes["name"].Value);
                                }
                            } else if (node.Name == "type") {
                                string tName = node.Attributes["name"].Value;
                                if (requestedExtensions.Contains(eName)) {
                                    IncludedTypes.Add(tName);
                                }
                                ExtensionTypes.Add(tName);
                            } else if (node.Name == "enum") {
                                if (requestedExtensions.Contains(eName)) {
                                    var extends = node.Attributes["extends"];
                                    if (extends != null) {
                                        var name = extends.Value;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
