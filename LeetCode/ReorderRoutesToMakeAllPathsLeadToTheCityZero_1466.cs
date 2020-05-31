using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466
    {
        public static int MinReorder(int n, int[][] connections)
        {
            var counter = 0;
            HashSet<int> hs = new HashSet<int>();
            foreach (var x in connections)
            {
                if (x.Contains(0)) 
                {
                    if (x[0] == 0)
                    {
                        counter++;
                        hs.Add(x[1]);
                    }
                    else
                    {
                        hs.Add(x[0]);
                    }
                }
                else
                {
                    if (!hs.Add(x[0])) 
                    { 
                        counter++;
                        hs.Add(x[1]);
                    }

                }

            }

            return counter;
        }
    }
}
