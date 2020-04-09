using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArray_26
    {
        public static int RemoveDuplicates(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            set.CopyTo(nums);
            return set.Count();
        }
    }
}
