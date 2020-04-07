using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class CountingElements
    {
        public static int CountElements(int[] arr)
        {
            return arr.Select(x => x + 1).Where(x => arr.Any(y => y == x)).Count();

        }
    }
}
