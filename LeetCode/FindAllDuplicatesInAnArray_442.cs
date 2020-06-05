using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class FindAllDuplicatesInAnArray_442
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            IList<int> res = new List<int>();
            HashSet<int> hs = new HashSet<int>();
            foreach (var n in nums)
            {
                if (!hs.Add(n))
                {
                    res.Add(n);
                }
            }
            return res.ToArray();
           // return nums.GroupBy(x => x).Where(x => x.Count() == 2).Select(x => x.Key).ToArray();

        }
    }
}
