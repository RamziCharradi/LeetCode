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

            Dictionary<char, char> IsIsoD = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!IsIsoD.ContainsKey(s[i]))
                {
                    if (IsIsoD.ContainsValue(t[i])) return false;
                    IsIsoD.Add(s[i], t[i]);
                }
                else
                {
                    if (IsIsoD[s[i]] != t[i]) return false;
                }
            }
            return true;
        }
    }
}
