using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class WordPattern_290
    {
        public static bool WordPattern(string pattern, string str)
        {
            var P = "";
            var S = "";
            var Array_Str = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var Array_Pat = pattern.ToCharArray();

            var D_str = Array_Str.GroupBy(x => x).ToDictionary(x => x.Key, x => Array.IndexOf(Array_Str, x.Key));

            foreach (var s in Array_Str)
            {
                P += D_str[s];
            }
            foreach (var c in Array_Pat)
            {
                S += Array.IndexOf(Array_Pat, c);
            }

            return P == S;
        }
    }
}
