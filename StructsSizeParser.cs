using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class StructsSizeParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "{";
        const string rightBrace = "}";

        const string filename = "Structs.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strMembers = "Members";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class StructDefinition {
            /*typedef struct VkAccelerationStructureCreateInfoNV {
    VkStructureType                  sType;
    const void*                      pNext;
    VkDeviceSize                     compactedSize;
    VkAccelerationStructureInfoNV    info;
} VkAccelerationStructureCreateInfoNV;
             */
            public string raw;

            static Dictionary<string, string> lower2sTypeDict = new Dictionary<string, string>();
            static StructDefinition() {
                foreach (var item in Enum.GetNames(typeof(VkStructureType))) {
                    lower2sTypeDict.Add(item.ToLower(), item);
                }
            }

            public string[] Dump() {
                string[] lines = this.raw.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
                if (lines == null || lines.Length < 2) { return lines; }

                string[] parts = lines[1].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                lines[0] = parts[2];

                return lines;
            }
        }

        public static void DumpStructs() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<StructDefinition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);

            using (var sw = new System.IO.StreamWriter("Structs.Sizes.gen.cs")) {
                sw.WriteLine($"var sizes = new int[] {leftBrace}");
                for (int i = 0; i < lstDefinition.Count; i++) {
                    StructDefinition definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();

                    sw.WriteLine($"    // Struct: {i}");
                    sw.WriteLine($"    sizeof({definitionLines[0]}),");
                }
                sw.WriteLine($"{rightBrace};");
            }
            Console.WriteLine("Done");
        }

        private static void TraverseDefinitions(XElement node, List<StructDefinition> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "C Specification") {
                    inside = true;
                }
            }
            else if (node.Name == "code") {
                if (inside) {
                    XAttribute attrClass = node.Attribute("class");
                    if (attrClass != null && attrClass.Value == "language-c++") {
                        string v = node.Value;
                        var item = new StructDefinition() { raw = v, };
                        list.Add(item);
                        inside = false;
                    }
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseDefinitions(item, list, ref inside);
            }
        }
    }
}
