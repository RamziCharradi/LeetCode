using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode
{
    public class CountPrimes_204
    {
        public static int CountPrimes(int n)
        {
            HashSet<int> blacklist = new HashSet<int>() { 0, 1 };
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (!blacklist.Contains(i))
                {
                    int cur = i * i;
                    while (cur < n)
                    {
                        blacklist.Add(cur);
                        cur += i;
                    }
                }
            }
            return Math.Max(0, n - blacklist.Count);
        }
    }
}
