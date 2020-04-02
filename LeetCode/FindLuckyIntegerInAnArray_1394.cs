using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class FindLuckyIntegerInAnArray_1394
    {
        public static int FindLucky(int[] arr) => arr.GroupBy(x => x).Where(x => x.Count() == x.Key)
                                      .Select(x => x.Key).OrderByDescending(x=>x)
                                      .DefaultIfEmpty(-1).First();
        
    }
}
