﻿using System;
using System.Collections.Generic;

namespace SpecReader {
    public class Struct {
        public string Name { get; set; }
        public List<Field> Fields { get; set; }
        public bool Union { get; set; }
        public bool Handle { get; set; }

        public Struct(string name, List<Field> fields, bool union) {
            Name = name;
            Fields = fields;
            Union = union;
            Handle = false;
        }
    }

    public class Field {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Pointer { get; set; }
        public string ArraySize { get; set; }

        public Field(string name, string type, bool pointer, string arraySize) {
            Name = name;
            Type = type;
            Pointer = pointer;
            ArraySize = arraySize;
        }
    }
}
