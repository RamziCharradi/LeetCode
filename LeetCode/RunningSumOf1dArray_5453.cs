using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class RunningSumOf1dArray_5453
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] res = new int[nums.Length];
            if (nums.Length > 0) res[0] = nums[0]; 
            for (int i = 1; i < nums.Length; i++)
            {
                res[i] = res[i - 1] + nums[i];
            }
            return res;
        }
    }
}
