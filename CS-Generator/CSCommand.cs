using System;
using System.Collections.Generic;

using VulkanGenerator;

namespace CS_Generator {
    public class CSCommand {
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public List<CSParam> Params { get; set; }

        public CSCommand(Command command) {
            Name = command.Name;
            ReturnType = GetType(command.ReturnType);
            Params = new List<CSParam>();

            foreach (var p in command.Params) {
                Params.Add(new CSParam(p));
            }
        }

        string GetType(string input) {
            if (input.Contains("PFN_")) return "IntPtr";
            return input;
        }
    }

    public class CSParam {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Pointer { get; set; }

        public CSParam(Param param) {
            Name = GetName(param.Name);
            Type = GetType(param.Type);
            foreach (char c in Type) {
                if (c == '*') Pointer++;
            }
        }

        string GetName(string input) {
            switch (input) {
                case "event": return "_event";
                case "object": return "_object";
                default: return input;
            }
        }

        string GetType(string input) {
            input = CSSpec.GetType(input);
            if (input.Contains("*")) {
                string type = input.Substring(0, input.Length - 1);
                if (CSSpec.IsPrimitive(type)) return "ref " + type;
            }
            if (input.Contains("*")) return "IntPtr";
            return input;
        }
    }
}
