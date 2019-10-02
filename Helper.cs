using System;
using System.Collections.Generic;
using System.Text;

namespace ApiSpec {
    class Helper {
        static readonly char[] braceSeparator = new char[] { '<', '>', };
        // remove <> </>
        /// <summary>
        /// Remove everything inside &lt;&gt; and &lt;/&gt;.
        /// </summary>
        /// <param name="strComment"></param>
        /// <returns></returns>
        public static string RemoveBraces(string strComment) {
            var builder = new StringBuilder();
            bool inside = false;
            foreach (var item in strComment) {
                if (item == '<') { inside = true; }
                else if (item == '>') { inside = false; }
                else {
                    if (!inside) {
                        builder.Append(item);
                    }
                }
            }

            return builder.ToString();
        }
        //static readonly char[] braceSeparator = new char[] { '<', '>', };
        //// remove <> </>
        //public static string RemoveBraces(string strComment) {
        //    var leftBraces = new List<int>();
        //    var rightBraces = new List<int>();
        //    for (int i = 0; i < strComment.Length; i++) {
        //        char c = strComment[i];
        //        if (c == '<') { leftBraces.Add(i); }
        //        else if (c == '>') { rightBraces.Add(i); }
        //    }

        //    if (leftBraces.Count != rightBraces.Count) { return strComment; }

        //    var builder = new StringBuilder();
        //    int current = 0; leftBraces.Add(strComment.Length); rightBraces.Insert(0, -1);
        //    for (int i = 0; i < leftBraces.Count; i++) {
        //        current = rightBraces[i] + 1;
        //        int left = leftBraces[i];
        //        string segment = strComment.Substring(current, left - current);
        //        if (!string.IsNullOrWhiteSpace(segment)) {
        //            builder.Append(segment);
        //        }
        //        else {
        //            builder.Append(" ");
        //        }
        //    }

        //    return builder.ToString();
        //}
    }
}
