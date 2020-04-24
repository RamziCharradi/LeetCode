using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Non_decreasing_Array_655
    {
        public static bool CheckPossibility(int[] nums)
        {
            int counter = 0;
            for (int i = 1; i < nums.Length-1; i++)
            {
                
                if (nums[i - 1] > nums[i])
                {
                    if (nums[i - 1] > nums[i + 1] && counter>0) return false;
                    if (nums[i] < nums[i + 1]) counter++;
                    else return false;
                }
                if (nums[nums.Length-2] > nums[nums.Length-1])
                {
                    
                    if (counter > 0) return false;
                    else counter++;
                }
            }

            return (counter == 1);
        }
    }
}
