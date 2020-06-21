using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class XOROperationInAnArray_1486
    {
        public static int XorOperation(int n, int start)
        {
            int index = 0;
            IEnumerable<int> nums = Enumerable.Range(start,n).Select(x => start + 2*index++);
            int ans = 0;
            foreach (var x in nums)
            {
                ans = ans ^ x;
            }

            return ans;

            /*
              int res = 0;

              for(int i = 0; i < n; i++)
              {
                  int temp  = start + 2 * i;
                  res ^= temp;
              }

              return res;

          */
        }

    }
}
