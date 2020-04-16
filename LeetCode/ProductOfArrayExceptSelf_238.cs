using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ProductOfArrayExceptSelf_238
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var prodNums = new int[nums.Length];
            var product = 1;

            for (int i = 0; i < nums.Length ; i++)
            {
                product *= nums[i];
                prodNums[i] = product;
            }

            var prodNumsBack = new int[nums.Length];
            var productBack = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                var x = (i + 1 >= nums.Length) ? 1 : prodNumsBack[i + 1];
                var y = (i - 1 < 0) ? 1 : prodNums[i - 1];
                productBack *= nums[i];
                prodNumsBack[i] = productBack;
                nums[i] = x * y;
            }

            return nums;
        }
    }
}
