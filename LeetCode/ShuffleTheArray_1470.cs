using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ShuffleTheArray_1470
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i+=2)
            {
                res[i ] = nums[i / 2];
                res[i + 1] = nums[i / 2 + n];
            }

            return res;
        }
    }
}
