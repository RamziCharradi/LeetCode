using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaximumAverageSubarrayI_643
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            // double x = nums.Take(k).Sum();
            double x = 0;
            for (int i = 0; i < k; i++) x += nums[i];
            
            double Result = x;

            for (int i = k; i < nums.Length ; i++)
            {
                x -= nums[i - k];
                x += nums[i];
                Result = Math.Max(Result, x);
            }

            return Result/(double)k;
        }
    }
}
