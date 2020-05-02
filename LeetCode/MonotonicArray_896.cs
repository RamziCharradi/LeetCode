using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MonotonicArray_896
    {
        public static bool IsMonotonic(int[] A)
        {

            //return A.OrderBy(x => x).ToArray().SequenceEqual(A) || A.OrderByDescending(x => x).ToArray().SequenceEqual(A);

            var length = A.Length;
            if (length < 3)
            {
                return true;
            }

            if (A[0] < A[length - 1])
            {
                for (int i = 1; i < length; i++)
                {
                    if (A[i - 1] > A[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (A[i - 1] < A[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
