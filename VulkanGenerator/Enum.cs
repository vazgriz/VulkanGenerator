using System;
using System.Collections.Generic;

namespace SpecReader {
    public class Enum {
        public string Name { get; set; }
        public bool Bitmask { get; set; }
        public List<EnumValue> Values { get; set; }

        public Enum(string name, bool bitmask, List<EnumValue> values) {
            Name = name;
            Bitmask = bitmask;
            Values = values;
        }

        public Enum(string name, bool bitmask) {
            Name = name;
            Bitmask = bitmask;
            Values = new List<EnumValue>();
        }

        public void Extend(string name, int extensionNumber, int offset, int sign) {
            int absValue = 1000000000 + ((extensionNumber - 1) * 1000) + offset;    //https://www.khronos.org/registry/vulkan/specs/1.0/styleguide.html#_assigning_extension_token_values
            int value = absValue * sign;
            Values.Add(new EnumValue(name, value.ToString()));
        }
    }

    public class EnumValue {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Bitpos { get; set; }

        public EnumValue(string name, string value) {
            Name = name;
            Value = value;
        }
    }
}
