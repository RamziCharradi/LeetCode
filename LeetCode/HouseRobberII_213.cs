using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HouseRobberII_213
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0 ) return 0;
            if (nums.Length == 1) return nums[0]; ;

            int[] dp = new int[nums.Length];
            dp[0] = 0;
            dp[1] = nums[0];
            for (int i = 1; i < nums.Length-1; i++)
            {
                dp[i + 1] = Math.Max(dp[i], nums[i] + dp[i - 1]);
            }

            int[] dp2 = new int[nums.Length];
            dp2[0] = 0;
            dp2[1] = nums[1];
            for (int i = 2; i < nums.Length ; i++)
            {
                dp2[i] = Math.Max(dp2[i-1], nums[i] + dp2[i - 2]);
            }

            return Math.Max(dp[nums.Length - 1], dp2[nums.Length - 1]);
        }
    }
}
