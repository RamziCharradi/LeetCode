using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReverseWordsInAStringIII_557
    {
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');
            var Output = new StringBuilder();
            foreach (var w in words)
            {
                Output.Append(new String(w.Select(x => x).Reverse().ToArray()));
                Output.Append(" ");
            }
            Output.Remove(Output.Length - 1, 1);
            return Output.ToString();
        }
    }
}
