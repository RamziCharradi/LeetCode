using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class KthMissingPositiveNumber_1539
    {
        public static int FindKthPositive(int[] arr, int k)
        {
            int i = 0;
            int x = 1;
            while (k > 0 && i<arr.Length)
            {
                if (arr[i] != x) k--;
                else i++;
                x++;
            }
            return x - 1 + k;
        }
    }
}
