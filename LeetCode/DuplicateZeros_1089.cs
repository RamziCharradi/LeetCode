using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DuplicateZeros_1089
    {
        public static int[] DuplicateZeros(int[] arr)
        {
            var Result = new int[arr.Length];
            var x = 0;
            var y = 0;
            while (y < arr.Length)
            {
                if (arr[x] == 0)
                {
                    Result[y++] = 0;
                    if (y < arr.Length) Result[y++] = 0;
                    else break;
                    x++;
                }
                else
                {
                    Result[y++]=arr[x++];
                }
            }

            Result.CopyTo(arr, 0);

            return Result;
        }

    }
}
