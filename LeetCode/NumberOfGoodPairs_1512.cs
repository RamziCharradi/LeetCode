using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumberOfGoodPairs_1512
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            int ans = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) ans++;
                }
            }

            return ans;
        }
    }
}
