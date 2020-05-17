using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ConsecutiveCharacters_1446
    {
        public static int MaxPower(string s)
        {
            var Result = 0;
            var counter = 0;
            var prev = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == prev)
                {
                    counter++;
                    Result = Math.Max(Result, counter);
                }
                else
                {
                    Result = Math.Max(Result, counter);
                    counter = 1;
                    prev = s[i];
                }
            }

            return Result;
        }
    }
}
