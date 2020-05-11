using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PowerOfThree_326
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1) return false;

            while (n>1)
            {
                if (n % 3 != 0) return false;
                else n /= 3 ;
            }
            return true;
        }
    }
}
