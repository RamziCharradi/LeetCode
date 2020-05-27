using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MaximumNumberOfVowelsInASubstringOfGivenLength_1456
    {
        public static int MaxVowels(string s, int k)
        {
            ISet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            int res = 0;
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    count++;
                }
            }

            res = count;

            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i - k]))
                {
                    count--;
                }

                if (vowels.Contains(s[i]))
                {
                    count++;
                }

                res = Math.Max(res, count);
            }

            return res;
        }
    }
}
