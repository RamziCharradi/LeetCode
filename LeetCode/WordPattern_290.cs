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

            if (pattern.Length != Array_Str.Length)
            {
                return false;
            }

            var Array_Pat = pattern.ToCharArray();

            var P = Array_Pat.Select(x => Array.IndexOf(Array_Pat, x)).ToList();
            var S = Array_Str.Select(x => Array.IndexOf(Array_Str, x)).ToList();
            
            return   P.SequenceEqual(S);
        }
    }
}
