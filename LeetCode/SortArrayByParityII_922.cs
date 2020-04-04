using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SortArrayByParityII_922
    {
        public static int[] SortArrayByParityII(int[] A)
        {
            int odd = 0;
            int even = 1;
            int[] Result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]% 2 == 0)
                {
                    Result[odd] = A[i];
                    odd += 2;
                }
                else
                {
                    Result[even] = A[i];
                    even += 2;
                }
            }
            return Result;
        }
    }
}
