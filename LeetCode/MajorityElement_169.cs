using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class MajorityElement_169
    {
        public static int MajorityElement(int[] nums) 
        {
            /*
             return  nums.GroupBy(x => x).Where(x => x.Count() > nums.Length / 2)
                         .Select(x => x.Key).FirstOrDefault();
             */
            return nums.GroupBy(x => x).Where(x => x.Count() > nums.Length / 2)
                        .First().Key;
        } 
    }
}
