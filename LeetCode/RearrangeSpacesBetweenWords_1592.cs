using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class RearrangeSpacesBetweenWords_1592
    {
        public static string ReorderSpaces(string text)
        {
            var spaces = text.Count(Char.IsWhiteSpace);
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int gap = words.Count() == 1 ? 0 : spaces / (words.Count() - 1);

            return string.Join(new String(' ', gap), words) + new String(' ', spaces - gap * (words.Count() - 1));
        }
    }
}
