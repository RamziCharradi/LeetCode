using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PascalTriangle_118
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> r = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                r.Add(new int[i+1]);
                r[i][0]  = 1;
                r[i][i] = 1 ;

                for (int j = 1; j < i; j++)
                    r[i][j] = r[i - 1][j - 1] + r[i - 1][j];
            }

            return r;



        }
    }
}
