using System;
using System.Collections.Generic;

using SpecReader;

namespace CppGenerator {
    public class CppEnum {
        public List<CppEnumValue> Values { get; private set; }

        public string Name { get; private set; }

        public CppEnum(SpecReader.Enum e) {
            Name = e.Name.Substring(2);

            Values = new List<CppEnumValue>();

            foreach (var v in e.Values) {
                Values.Add(new CppEnumValue(v));
            }
        }
    }

    public class CppEnumValue {
        public string Name { get; private set; }

        public CppEnumValue(EnumValue v) {
            Name = GetName(v);
        }

        string GetName(EnumValue v) {
            return v.Name;
        }
    }
}
