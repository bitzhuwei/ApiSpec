﻿using System;
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

        public static void Dump() {
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
                            sw.WriteLine($"    /// <summary>");
                            sw.WriteLine($"    /// Allocate <paramref name=\"count\"/> instances of <see cref=\"{definitionLines[0]}\"/> in unmanaged memory.");
                            sw.WriteLine($"    /// <para>The 'sType' member is already set up.</para>");
                            sw.WriteLine($"    /// </summary>");
                            sw.WriteLine($"    /// <param name=\"count\">how many items to allocate?</param>");
                            sw.WriteLine($"    /// <returns>A pointer to the instances of <see cref=\"{definitionLines[0]}\"/>.</returns>");
                            sw.WriteLine($"    public static {definitionLines[0]}* Alloc(int count = 1) {leftBrace}");
                            {
                                sw.WriteLine($"        if (count <= 0) {leftBrace} return null; {rightBrace}");
                                sw.WriteLine($"        ");
                                sw.WriteLine($"        int size = sizeof({definitionLines[0]});");
                                sw.WriteLine($"        var info = ({definitionLines[0]}*)Marshal.AllocHGlobal(size * count);");
                                sw.WriteLine($"        for (int i = 0; i < count; i++) {leftBrace} Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); { rightBrace}");
                                string sType = definitionLines[1] != "0" ? "VkStructureType." + definitionLines[1] : "0";
                                sw.WriteLine($"        for (int i = 0; i < count; i++) {leftBrace} info[i].sType = {sType}; {rightBrace}");
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
                            sw.WriteLine($"    /// <summary>");
                            sw.WriteLine($"    /// Allocate <paramref name=\"count\"/> instances of <see cref=\"{definitionLines[0]}\"/> in unmanaged memory.");
                            sw.WriteLine($"    /// <para>No 'sType' member exists in this struct.</para>");
                            sw.WriteLine($"    /// </summary>");
                            sw.WriteLine($"    /// <param name=\"count\">how many items to allocate?</param>");
                            sw.WriteLine($"    /// <returns>A pointer to the instances of <see cref=\"{definitionLines[0]}\"/>.</returns>");
                            sw.WriteLine($"    public static {definitionLines[0]}* Alloc(int count = 1) {leftBrace}");
                            {
                                sw.WriteLine($"        if (count <= 0) {leftBrace} return null; {rightBrace}");
                                sw.WriteLine($"        ");
                                sw.WriteLine($"        int size = sizeof({definitionLines[0]});");
                                sw.WriteLine($"        var info = ({definitionLines[0]}*)Marshal.AllocHGlobal(size * count);");
                                sw.WriteLine($"        for (int i = 0; i < count; i++) {leftBrace} Marshal.Copy(Vk.zeros, 0, (IntPtr)(&(info[i])), size); {rightBrace}");
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        /// <param name="inside"></param>
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
