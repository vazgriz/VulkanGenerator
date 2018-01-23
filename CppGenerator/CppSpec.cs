using System;
using System.Collections.Generic;

using SpecReader;

namespace CppGenerator {
    public class CppSpec {
        public List<CppEnum> Enums { get; private set; }

        public CppSpec(Spec spec) {
            Enums = new List<CppEnum>();

            foreach (var e in spec.EnumMap.Values) {
                if (e.Name.Contains("Flags")) continue;
                Enums.Add(new CppEnum(e));
            }
        }
    }
}
