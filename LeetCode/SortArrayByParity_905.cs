using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class SortArrayByParity_905
    {
        public static int[] SortArrayByParity(int[] A)
        {
            return A.Where(x => x % 2 == 0)
                    .Concat(A.Where(x => x % 2 == 1))
                    .ToArray();
            
        }
       
    }
}
