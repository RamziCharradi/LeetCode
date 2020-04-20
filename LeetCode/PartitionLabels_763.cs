using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class PartitionLabels_763
    {
        public static IList<int> PartitionLabels(string S)
        {
            IList<int> Result = new List<int>();
            var arr = S.ToCharArray();

            int counter = 1;
            int start = 0;
            int index = 0;
            if (Array.LastIndexOf(arr, arr[0]) == S.Length) return new List<int>() { S.Length };

            
            while (index < S.Length && start<S.Length)
            {
                index = Array.LastIndexOf(arr, arr[start]);
                test:
                if (arr.Skip(start).Take(index + 1 - start).Distinct().Count() != counter)
                {
                    counter = 0;
                    foreach (var c in arr.Skip(start).Take(index + 1 - start ).Distinct())
                    {
                        index = Math.Max(index, Array.LastIndexOf(arr, c));
                        counter++;
                    }
                    goto test;
                }
                else
                {
                    Result.Add(index + 1 -start);
                    start = index + 1;
                    counter = 1;
                }
            }



            return Result;
        }
    }
}
