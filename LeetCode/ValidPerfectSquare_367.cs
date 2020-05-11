using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ValidPerfectSquare_367
    {
        public static bool IsPerfectSquare(int num)
        {
            var x = 1;
            while (x <= num / x)
            {
                if (x * x == num) return true;
                x++;
            }
            return false;
        }
    }
}
