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
            var Array_Str = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var Array_Pat = pattern.ToCharArray();

            return Array_Pat.Select(x => Array.IndexOf(Array_Pat, x)).ToList()
                    .SequenceEqual(Array_Str.Select(x => Array.IndexOf(Array_Str, x)).ToList());

        }
    }
}
