using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsSubsequence_392
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            if (s.Length > t.Length) return false;
            int curr = 0;
            int counter = 0;
            while (curr < t.Length && counter<s.Length)
            {
                if (s[counter] == t[curr]) counter++;
                curr++;
            }

            return counter == s.Length;
        }
    }
}
