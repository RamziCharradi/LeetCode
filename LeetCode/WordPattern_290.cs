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

            var D_str = Array_Str.GroupBy(x=>x).ToDictionary(x => x.Key, x => Array.IndexOf(Array_Str, x.Key));

            for (int i = 0; i < Array_Pat.Length; i++)
            {
                if(Array.IndexOf(Array_Pat, Array_Pat[i]) != D_str[Array_Str[i]])
                {
                    return false;
                }
            }


            return true;
        }
    }
}
