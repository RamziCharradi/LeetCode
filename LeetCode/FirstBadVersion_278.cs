using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FirstBadVersion_278
    {
        public static int FirstBadVersion(int n)
        {
            int left = 0;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;

        }

        static bool IsBadVersion(int version)
        {
            if (version == 4) return true;
            return false;
        }
    }
}
