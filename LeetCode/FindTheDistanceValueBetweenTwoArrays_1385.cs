using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class FindTheDistanceValueBetweenTwoArrays_1385
    {
        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            return arr1.Where(x => !arr2.Any(y => Math.Abs(x - y) <= d)).Count();
        }
    }
}
