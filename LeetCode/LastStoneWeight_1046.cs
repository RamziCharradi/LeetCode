using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class LastStoneWeight_1046
    {
        public static int LastStoneWeight(int[] stones)
        {
            Array.Sort(stones);
            List<int> l = stones.ToList();
            int lastIdx = l.Count - 1;
            int prevIdx = lastIdx - 1;

            while (lastIdx > 0)
            {
                l[prevIdx] = l[lastIdx] - l[prevIdx];
                l.RemoveAt(lastIdx);
                l.Sort();
                lastIdx--;
                prevIdx--;
            }

            return l[lastIdx];


            //Array.Sort(stones);
            //List<int> l = stones.ToList();
            //while (l.Count > 1)
            //{
            //    int Max1 = l[l.Count - 1];
            //    int Max2 = l[l.Count - 2];
            //    l.RemoveAt(l.Count - 1);
            //    l.RemoveAt(l.Count - 1);

            //    if (Max1 != Max2)
            //    {
            //        int liIndex = l.BinarySearch(Max1 - Max2);

            //        if (liIndex < 0)
            //            liIndex = ~liIndex;

            //        l.Insert(liIndex, Max1 - Max2);
            //    }
            //}

            //return l.Count == 0 ? 0 : l[0];
        }
    }
}
