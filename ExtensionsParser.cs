using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ApiSpec {
    class ExtensionsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', '(', ')' };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "(";
        const string rightBrace = ")";

        const string filename = "Extensions.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class Definition {
            /*<a href="#_vk_khr_16bit_storage3">VK_KHR_16bit_storage(3)</a>
             */
            public string raw;

            static readonly char[] separator = new char[] { ' ', '\t', '\r', '\n', '(' };
            public string[] Dump() {
                var result = new string[2];
                string[] parts = this.raw.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                result[0] = parts[0];

                return result;
            }
        }

        public static void Dump() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<Definition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);

            using (var sw = new System.IO.StreamWriter("Extensions.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    Definition definition = lstDefinition[i];
                    string[] parts = definition.Dump();
                    sw.WriteLine($"public const string {parts[0]} = \"{parts[0]}\";");
                }
            }
            Console.WriteLine("Done");
        }

        private static void TraverseDefinitions(XElement node, List<Definition> list, ref bool inside) {
            if (node.Name == "a") {
                string v = node.Value;
                var item = new Definition() { raw = v, };
                list.Add(item);
                inside = false;
            }

            foreach (XElement item in node.Elements()) {
                TraverseDefinitions(item, list, ref inside);
            }
        }
    }
}
