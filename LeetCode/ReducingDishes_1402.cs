using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReducingDishes_1402
    {
        public static int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            Array.Reverse(satisfaction);
            if (satisfaction[0] <= 0) return 0;
            
            int ans = 0;
            int cum = 0;
            int curr = 0;

            for (int i = 0; i < satisfaction.Length; i++)
            {
                curr += cum + satisfaction[i];
                cum += satisfaction[i];
                ans = Math.Max(ans, curr);
            }

            return ans;
        }
    }
}
