using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RotatedDigits_788
    {
        public static int RotatedDigits(int N)
        {

            int count = 0;
            for (int i = 2; i <= N; i++)
            {
                if (IsGood(i))
                {
                    count++;
                }
            }
            return count;
        }

        private static bool IsGood(int n)
        {
            bool isGood = false;
            while (n > 0)
            {
                int m = n % 10;
                if (m == 3 || m == 4 || m == 7)
                {
                    return false;
                }
                if (m == 2 || m == 5 || m == 6 || m == 9)
                {
                    isGood = true;
                }
                n /= 10;
            }
            return isGood;
        }
    }
}
