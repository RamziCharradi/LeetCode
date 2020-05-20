using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MaximumScoreAfterSplittingAString_1422
    {
        public static int MaxScore(string s)
        {
            var right = s.Where(x=>x=='1').Count();
            var left = 0;
            var Result = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == '0') left++;
                else right--;

                Result = Math.Max(Result, right + left);
            }

            return Result;
        }
    }
}
