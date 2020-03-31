using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DeleteColumnsToMakeSorted_944
    {
        public static int MinDeletionSize(string[] A)
        {
            var Result = 0;
            for (int i = 0; i <A[0].Length ; i++)
            {
                bool test = false;
                var prev = A[0][i];
                for (int j = 0; j < A.Length; j++)
                {
                    if( prev> A[j][i])
                    {
                        test = true;
                        break;

                    }
                    prev = A[j][i];
                }
                if (test) Result++; 
            }

            return Result;
        }
    }
}
