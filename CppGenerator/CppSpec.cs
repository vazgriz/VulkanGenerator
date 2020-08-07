using System;
using System.Collections.Generic;

using SpecReader;

namespace CppGenerator {
    public class CppSpec {
        public List<CppEnum> Enums { get; private set; }
        public Dictionary<string, int> SuffixNameMap { get; private set; }

        public CppSpec(Spec spec) {
            Enums = new List<CppEnum>();
            SuffixNameMap = new Dictionary<string, int>();

            foreach (var e in spec.EnumMap.Values) {
                AddEnumToSuffixMap(e.Name, spec.Suffixes);
            }

            foreach (var e in spec.EnumMap.Values) {
                if (e.Name.Contains("Flags")) continue;
                Enums.Add(new CppEnum(spec, e, spec.Suffixes, SuffixNameMap));
            }
        }

        void AddEnumToSuffixMap(string name, List<string> suffixes) {
            foreach (var suffix in suffixes) {
                int index = name.IndexOf(suffix);
                string newName = name;

                if (index != -1) {
                    newName = name.Substring(0, index);
                }

                if (SuffixNameMap.TryGetValue(newName, out int value)) {
                    SuffixNameMap[newName] = value + 1;
                } else {
                    SuffixNameMap.Add(newName, 1);
                }
            }
        }
    }
}
