using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SqrtX_69
    {
        public static int MySqrt(int x)
        {
            var n = 1;
            while (n <= x / n)
            {
                if (n * n == x) return n;
                n++;
            }
            return n - 1;
        }
    }
}
