using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class ContainerWithMostWater_11
    {
        public static int MaxArea(int[] height)
        {
            var max = 0;
            for (int i = 0; i < height.Length-1; i++)
            {
                for (int j = height.Length-1 ; j >i ; j--)
                {
                    max = Math.Max(max, (j - i) * (Math.Min(height[i], height[j])));
                }
            }

            return max;
        }
    }
}
