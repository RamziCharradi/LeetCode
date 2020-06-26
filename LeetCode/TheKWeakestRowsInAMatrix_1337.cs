using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class TheKWeakestRowsInAMatrix_1337
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            return Enumerable.Range(0, mat.Length)
                             .OrderBy(x => mat[x].Sum()).Take(k).ToArray();
        }
    }
}
