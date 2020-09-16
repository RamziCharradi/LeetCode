using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SpecialPositionsInABinaryMatrix_1582
    {
        public static int NumSpecial(int[][] mat)
        {
            int ans = 0;
            int[] rows = new int[mat[0].Length];
            int[] cols = new int[mat.Length];

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        ++rows[j];
                        ++cols[i];
                    }
                }
            }

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 1 && rows[j] == 1 && cols[i] == 1)
                    {
                        ++ans;
                    }
                }
            }

            return ans;
        }
    }
}
