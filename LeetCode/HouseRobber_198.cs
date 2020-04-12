using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HouseRobber_198
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i+1] = Math.Max(dp[i],nums[i]+dp[i-1]);
            }

            return dp[nums.Length];
        }
    }
}
