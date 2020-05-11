using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SumOfSquareNumbers_633
    {
        public static bool JudgeSquareSum(int c)
        {
            if (c < 0)
                return false;

            int start = 0;
            int end = (int)Math.Sqrt(c);
            while (start <= end)
            {
                var smaller = start * start;
                var bigger = end * end;
                var sum = smaller + bigger;
                if (sum == c)
                    return true;
                if (sum < c)
                    start++;
                else
                    end--;
            }

            return false;
        }
    }
}
