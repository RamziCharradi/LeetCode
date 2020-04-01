using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ValidPalindromeII_680
    {
        public static bool ValidPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                    break;
                i++; j--;
            }
            if (i >= j) return true;
            return (IsPalindrome(s.Substring(i, j - i)) || IsPalindrome(s.Substring(i + 1, j - i)));
        }
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0) return true;
            int i = 0, j = s.Length - 1;
                while (i < j)
                {
                    if (s[i] != s[j])
                        break;
                    i++; j--;
                }
            if (i >= j) return true;
            return false;
        }
    }

}
