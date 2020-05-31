using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MaximumProductOfTwoElementsInAnArray_1464
    {
        public static int MaxProduct(int[] nums)
        {
            return nums.Select(x => x - 1).OrderByDescending(x => x).Take(1).First() *
                   nums.Select(x => x - 1).OrderByDescending(x => x).Skip(1).Take(1).First();

            /*
            var l = nums.Select(x => x - 1).OrderByDescending(x => x).Take(2).ToArray();
            return l[0]*l[1];
            */
        }
    }
}
