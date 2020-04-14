using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsomorphicStrings_205
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> ds = new Dictionary<char, int>();
            Dictionary<char, int> dt = new Dictionary<char, int>();
            int i = 0;
            string ss = "";
            string tt = "";
            foreach (var c in s)
            {
                if (!ds.ContainsKey(c))
                {
                    ds.Add(c, i);
                    ss += i;
                    i++;
                }
                else
                {
                    ss += ds[c];
                }
            }
            i = 0;
            foreach (var c in t)
            {
                if (!dt.ContainsKey(c))
                {
                    dt.Add(c, i);
                    tt += i;
                    i++;
                }
                else
                {
                    tt += dt[c];
                }
            }

            return ss == tt;

        }
    }
}
