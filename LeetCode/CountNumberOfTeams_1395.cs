using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class CountNumberOfTeams_1395
    {
        public static int NumTeams(int[] rating)
        {
            int n = rating.Length; 
            int count = 0;

            for (int i = 1; i < n - 1; i++)
            {
                int curr = rating[i];
                int leftSmaller = 0;
                int leftBigger = 0;
                int rightSmaller = 0;
                int rightBigger = 0;
                //2,5,3,4,1
                for (int l = 0; l < i; l++)
                {
                    if (rating[l] < curr) leftSmaller++; //1
                    if (rating[l] > curr) leftBigger++; //1
                }

                for (int r = i + 1; r < n; r++)
                {
                    if (rating[r] < curr) rightSmaller++; //1
                    if (rating[r] > curr) rightBigger++; //1
                }

                count += (leftSmaller * rightBigger) + (leftBigger * rightSmaller);
            }
            return count;

        }

   
    }
}
