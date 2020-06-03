using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class QueriesOnAPermutationWithKey_1409
    {
        public static int[] ProcessQueries(int[] queries, int m)
        {
            List<int> l = Enumerable.Range(1, m).ToList();
            Queue<int> Result = new Queue<int>();
            foreach (var q in queries)
            {
                Result.Enqueue(l.IndexOf(q));
                l.RemoveAt(l.IndexOf(q));
                l.Insert(0, q);
            }

            return Result.ToArray();
        }
    }
}
