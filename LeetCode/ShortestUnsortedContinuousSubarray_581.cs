using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ShortestUnsortedContinuousSubarray_581
    {
        public static int FindUnsortedSubarray(int[] nums)
        {
            int[] Sorted = new int[nums.Length];
            Array.Copy(nums, Sorted, nums.Length);
            Array.Sort(Sorted);

            // int[] Sorted = nums.OrderBy(x => x).ToArray();
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != Sorted[i])
                {
                    start = i - 1;
                    break;
                }
            }
            int Finish = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != Sorted[i])
                {
                    Finish = i;
                    break;
                }
            }

            return Finish - start;
        }
    }
}
