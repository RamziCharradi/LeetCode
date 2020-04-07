using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class FindTheTownJudge_997
    {
        public static int FindJudge(int N, int[][] trust)
        {
            List<int> TrustNobody = (List<int>)Enumerable.Range(1, N).ToList()
                                    .Where(x => !trust.Any(y => y[0] == x)).ToList();
                                        

            foreach (var x in TrustNobody)
            {
                if(trust.Select(y => y).Select(y => y[1]).Where(y => y == x).Count() == N - 1)
                {
                    return x;
                }
            }

            return -1;
        }
    }
}
