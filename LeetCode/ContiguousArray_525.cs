using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ContiguousArray_525
    {
        public static int FindMaxLength(int[] nums)
        {
            var count = 0;
            var dict = new Dictionary<int, int>();
            dict[0] = -1;
            var max = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                count += (nums[i] == 0 ? -1 : 1);
              
                if (dict.ContainsKey(count))
                {
                    max = Math.Max(max, i - dict[count]);
                }
                else
                {
                    dict[count] = i;
                }
            }
            return max;
        }
    }
}
