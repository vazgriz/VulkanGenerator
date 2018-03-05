using System;
using System.Collections.Generic;
using System.Xml;

namespace SpecReader {
    public class Spec {
        int major;
        int minor;
        HashSet<string> requestedExtensions;

        public List<string> Suffixes { get; private set; }
        public List<Enum> Enums { get; private set; }
        public HashSet<string> AllEnums { get; private set; }
        public List<Command> Commands { get; private set; }
        public List<Struct> Structs { get; private set; }
        public HashSet<string> IncludedCommands { get; private set; }
        public HashSet<string> IncludedTypes { get; private set; }
        public HashSet<string> ExtensionTypes { get; private set; }
        public HashSet<string> ExtensionCommands { get; private set; }
        public Dictionary<string, string> EnumValuesMap { get; private set; }

        public Dictionary<string, Enum> EnumMap { get; private set; }
        public Dictionary<string, Struct> StructMap { get; private set; }

        public Spec(XmlDocument doc, int major, int minor, List<string> extensions) {
            this.major = major;
            this.minor = minor;
            requestedExtensions = extensions != null ? new HashSet<string>(extensions) : null;

            Suffixes = new List<string>();
            Enums = new List<Enum>();
            AllEnums = new HashSet<string>();
            Commands = new List<Command>();
            Structs = new List<Struct>();
            IncludedCommands = new HashSet<string>();
            IncludedTypes = new HashSet<string>();
            ExtensionTypes = new HashSet<string>();
            ExtensionCommands = new HashSet<string>();
            EnumValuesMap = new Dictionary<string, string>();

            EnumMap = new Dictionary<string, Enum>();
            StructMap = new Dictionary<string, Struct>();

            Load(doc);
        }

        bool ExtensionRequested(string name) {
            if (requestedExtensions != null) {
                return requestedExtensions.Contains(name);
            } else {
                return true;
            }
        }

        void Load(XmlDocument doc) {
            var root = doc.ChildNodes[1];
            for (int i = 0; i < root.ChildNodes.Count; i++) {
                var node = root.ChildNodes[i];
                if (node is XmlComment) continue;
                if (node.Name == "tags") {
                    LoadTags(node);
                } else if (node.Name == "types") {
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

        void LoadTags(XmlNode root) {
            foreach (XmlNode node in root.ChildNodes) {
                if (node is XmlComment) continue;
                Suffixes.Add(node.Attributes["name"].Value);
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
                            if (fNode.Name == "comment") continue;
                            if (fNode.Name == "validity") continue;
                            LoadField(fNode, fields);
                        }

                        var s = new Struct(name, fields, union);
                        Structs.Add(s);
                        StructMap.Add(name, s);
                    } else if (cat == "handle") {
                        string name = node["name"].InnerText;
                        List<Field> fields = new List<Field>();
                        var s = new Struct(name, fields, false);
                        s.Handle = true;

                        if (node["type"].InnerText == "VK_DEFINE_HANDLE") {
                            fields.Add(new Field("native", "IntPtr", false, null));
                        } else {
                            fields.Add(new Field("native", "ulong", false, null));
                        }

                        Structs.Add(s);
                        StructMap.Add(name, s);
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

            string arraySize = null;
            if (root.InnerText.Contains("[")) {
                XmlNode e = root["enum"];
                if (e == null) {
                    int start = root.InnerText.IndexOf('[');
                    int end = root.InnerText.IndexOf(']');
                    arraySize = root.InnerText.Substring(start + 1, (end - start) - 1);
                } else {
                    arraySize = root["enum"].InnerText;
                }
            }

            var f = new Field(name, type, pointer, arraySize);
            fields.Add(f);
        }

        void LoadEnums(XmlNode root) {
            string name = root.Attributes["name"].Value;

            if (name == "API Constants") {
                foreach (XmlNode node in root.ChildNodes) {
                    if (node is XmlComment) continue;
                    if (node.Name != "enum") continue;
                    string vName = node.Attributes["name"].Value;
                    var att = node.Attributes["value"] ?? node.Attributes["bitpos"];
                    string value = att.Value;
                    EnumValuesMap.Add(vName, value);
                }
                return;
            }
            List<EnumValue> values = new List<EnumValue>();
            foreach (XmlNode node in root.ChildNodes) {
                if (node is XmlComment) continue;
                if (node.Name != "enum") continue;
                string vName = node.Attributes["name"].Value;
                var att = node.Attributes["value"] ?? node.Attributes["bitpos"];
                string value = att.Value;
                bool bitpos = att.Name == "bitpos";
                var v = new EnumValue(vName, value);
                v.Bitpos = bitpos;
                values.Add(v);
                EnumValuesMap.Add(vName, value);
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
            int pointer = 0;

            foreach (char c in root.InnerText) {
                if (c == '*') {
                    type += c;
                    pointer++;
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
                        if (f.Name == "command") {
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
                                if (ExtensionRequested(eName)) {
                                    IncludedCommands.Add(node.Attributes["name"].Value);
                                    ExtensionCommands.Add(node.Attributes["name"].Value);
                                }
                            } else if (node.Name == "type") {
                                string tName = node.Attributes["name"].Value;
                                if (ExtensionRequested(eName)) {
                                    IncludedTypes.Add(tName);
                                }
                                ExtensionTypes.Add(tName);
                            } else if (node.Name == "enum") {
                                if (ExtensionRequested(eName)) {
                                    var extends = node.Attributes["extends"];
                                    var offsetNode = node.Attributes["offset"];
                                    if (extends != null && offsetNode != null) {
                                        var name = extends.Value;
                                        var exNumber = int.Parse(extension.Attributes["number"].Value);
                                        var offset = int.Parse(offsetNode.Value);
                                        var sign = 1;
                                        if (node.Attributes["dir"] != null) {
                                            sign = -1;
                                        }
                                        EnumMap[name].Extend(node.Attributes["name"].Value, exNumber, offset, sign);
                                    }
                                    IncludedTypes.Add(node.Attributes["name"].Value);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
