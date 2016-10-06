using System;
using System.IO;
using System.Collections.Generic;

namespace Generator {
    public class Offsets {
        Dictionary<string, Offset> offsets;

        public Offsets(Stream stream) {
            offsets = new Dictionary<string, Offset>();
            Read(stream);
        }

        public Offset this[string index] {
            get {
                return offsets[index];
            }
        }

        public bool Contains(string index) {
            return offsets.ContainsKey(index);
        }

        void Read(Stream stream) {
            List<string> lines = new List<string>();
            using (var reader = new StreamReader(stream)) {
                while (!reader.EndOfStream) {
                    lines.Add(reader.ReadLine());
                }
            }

            int i = 0;
            while (i < lines.Count) {
                string name = lines[i];
                var list = new List<int>();
                i++;
                int size = int.Parse(lines[i]);
                i++;
                var offset = new Offset(list, size);
                offsets.Add(name, offset);
                ReadFields(lines, ref i, list);
            }
        }

        void ReadFields(List<string> lines, ref int i, List<int> offsets) {
            while (i < lines.Count) {
                var line = lines[i];
                if (line == "") break;
                int index = line.LastIndexOf(" ");
                index++;

                string token = line.Substring(index, line.Length - index);
                offsets.Add(int.Parse(token));

                i++;
            }
            i++;
        }
    }

    public struct Offset {
        public List<int> offsets;
        public int size;

        public Offset(List<int> offsets, int size) {
            this.offsets = offsets;
            this.size = size;
        }
    }
}
