using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class SearchInRotatedSortedArray_33
    {
        public static int Search(int[] nums, int target)
        {
            int[] sorted = new int[nums.Length];
            nums.CopyTo(sorted,0);
            Array.Sort(sorted);
            if (!sorted.Contains(target)) return -1;

            var rank = Array.IndexOf(sorted,target);
            var Rotation = Array.IndexOf(nums,sorted[0]);

            //if (rank + Rotation >= nums.Length) return (rank + Rotation) % nums.Length;
            //return rank + Rotation;
            return (rank + Rotation) % nums.Length;
        }
    }
}
