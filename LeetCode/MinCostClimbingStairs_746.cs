using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinCostClimbingStairs_746
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int a = cost[0];
            int b = cost[1];
            int c = 0;
            for (int i = 2; i < cost.Length; i++)
            {
               c = cost[i] + Math.Min(a, b);
               a = b;
               b = c;
                
            }
            return Math.Min(a,b);
        }
    }
}
