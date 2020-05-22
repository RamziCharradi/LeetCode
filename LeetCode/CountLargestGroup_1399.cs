using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class CountLargestGroup_1399
    {
        public static int CountLargestGroup(int n)
        {
            var list = Enumerable.Range(1, n)
                                .GroupBy(SumOfDigits)
                                .ToList();

            int m = list.Max(x => x.Count());

            return list.Count(x => x.Count() == m);

            int SumOfDigits(int k)
            {
                int num = 0;
                while (k != 0)
                {
                    num += k % 10;
                    k /= 10;
                }

                return num;

            }
        }


    }
}
