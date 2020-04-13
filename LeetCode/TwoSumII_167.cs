using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TwoSumII_167
    {
        public static int[] TwoSum(int[] numbers, int target)
        {

            HashSet<int> hs = new HashSet<int>(numbers); 

            for (int i = 0; i < numbers.Length; i++)
            {
                if (hs.Contains(target - numbers[i]))
                {
                    return new int[] { i+1, Array.IndexOf(numbers, target - numbers[i]) +1 };
                }
            }

            return new int[] {};
        }
    }
}
