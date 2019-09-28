using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class StructsMarshalParser {

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
                if (parts.Length > 1 && parts[1] == "sType;") {
                    parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    lines[0] = parts[2];
                    string lower = parts[2].Substring(2).ToLower();
                    string value = string.Empty;
                    if (lower2sTypeDict.TryGetValue(lower, out value)) {
                        lines[1] = value;
                    }
                    else {
                        lines[1] = "0";
                    }
                }
                else {
                    parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    lines[0] = parts[2];
                    lines[1] = string.Empty;
                }

                return lines;
            }
        }

        public static void DumpStructs() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<StructDefinition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);

            using (var sw = new System.IO.StreamWriter("Structs.Marshal.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    StructDefinition definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();

                    sw.WriteLine($"// Struct: {i}");
                    if (definitionLines[1] != string.Empty) {
                        sw.WriteLine($"public unsafe partial struct {definitionLines[0]} {leftBrace}");
                        {
                            sw.WriteLine($"    public static {definitionLines[0]}* Alloc() {leftBrace}");
                            {
                                sw.WriteLine($"        int size = sizeof({definitionLines[0]});");
                                sw.WriteLine($"        var info = ({definitionLines[0]}*)Marshal.AllocHGlobal(size);");
                                sw.WriteLine($"        Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);");
                                if (definitionLines[1] != "0") {
                                    sw.WriteLine($"        info->sType = VkStructureType.{definitionLines[1]};");
                                }
                                else {
                                    sw.WriteLine($"        info->sType = 0;");
                                }
                                sw.WriteLine();
                                if (definitionLines[1] == "0"
                                    && (definitionLines[0] != "VkBaseInStructure")
                                    && (definitionLines[0] != "VkBaseOutStructure")
                                    ) {
                                    sw.WriteLine($"        throw new Exception(\"No suitable sType found!\");");
                                }
                                sw.WriteLine($"        return info;");
                            }
                            sw.WriteLine($"    {rightBrace}");
                        }
                        sw.WriteLine($"{rightBrace}");
                        sw.WriteLine();
                    }
                    else {
                        sw.WriteLine($"public unsafe partial struct {definitionLines[0]} {leftBrace}");
                        {
                            sw.WriteLine($"    public static {definitionLines[0]}* Alloc() {leftBrace}");
                            {
                                sw.WriteLine($"        int size = sizeof({definitionLines[0]});");
                                sw.WriteLine($"        var info = ({definitionLines[0]}*)Marshal.AllocHGlobal(size);");
                                sw.WriteLine($"        Marshal.Copy(Vk.zeros, 0, (IntPtr)info, size);");
                                sw.WriteLine();
                                sw.WriteLine($"        return info;");
                            }
                            sw.WriteLine($"    {rightBrace}");
                        }
                        sw.WriteLine($"{rightBrace}");
                        sw.WriteLine();
                    }
                }
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
