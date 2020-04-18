using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MinimumValueToGetPositiveStepByStepSum_1413
    {
        public static int MinStartValue(int[] nums)
        {
            int min = 1;
            while (1 == 1)
            {
                int sum = min;
                int counter = 0;
                foreach (var x in nums)
                {
                    sum += x;
                    if (sum < 1)
                    {
                        min++;
                        break;
                    }
                    counter++;
                }
                if (counter == nums.Length) return min;
            }
        }
    }
}
