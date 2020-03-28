using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinimumAbsoluteDifference_1200
    {
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> l = new List<IList<int>>();
            Array.Sort(arr);

            int min = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = (arr[i + 1] > arr[i]) ? arr[i + 1] - arr[i] : 0;

                if (diff < min)
                {
                    l.Clear();
                    l.Add(new List<int>() { arr[i], arr[i + 1] });
                    min = diff;
                }
                else if (diff == min)
                {
                    l.Add(new List<int>() { arr[i], arr[i + 1] });
                }

            }

            return l;

        }
    }
}
