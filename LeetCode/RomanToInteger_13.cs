using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RomanToInteger_13
    {
        public static int RomanToInt(string s)
        {
            var n = s.Length;
            var romanAndInt = new Dictionary<char, int>()
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };

            var result = romanAndInt[s[n - 1]];

            for (int i = s.Length - 2; i >= 0; i--)
            {
                var cur = romanAndInt[s[i]];
                var post = romanAndInt[s[i + 1]];

                if (cur < post)
                {
                    result -= cur;
                }
                else
                {
                    result += cur;
                }
            }

            return result;

        }
    }
}
