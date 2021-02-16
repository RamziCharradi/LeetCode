using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class SumOfUniqueElements_1748
    {
        public int SumOfUnique(int[] nums)
        {

            return nums.GroupBy(x => x)
                       .Where(x => x.Count() < 2)
                       .Select(x => x.Key)
                       .Sum();

        }

    }
}
