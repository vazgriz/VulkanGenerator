using System;
using System.Collections.Generic;

namespace VulkanGenerator {
    public class Command {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public List<Param> Params { get; set; }

        public List<string> SuccessCodes { get; set; }
        public List<string> ErrorCodes { get; set; }

        public Command(string name, string returnType) {
            Name = name;
            ReturnType = returnType;
        }
    }

    public class Param {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Pointer { get; set; }

        public Param(string name, string type, int pointer) {
            Name = name;
            Type = type;
            Pointer = pointer;
        }
    }
}
