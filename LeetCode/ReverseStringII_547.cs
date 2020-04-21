using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReverseStringII_547
    {
        public static string ReverseStr(string s, int k)
        {
            if (s.Length < 2) return s;

            var counter = 0;
            var rest = 0;
            var Result = "";
            while (counter < s.Length)
            {
                rest = s.Length - counter;

                if (rest < k) Result += Reverse(new String(s.Skip(counter).ToArray()));
                else Result += Reverse(new String(s.Skip(counter).Take(k).ToArray()))
                            + new String(s.Skip(counter + k).Take(k).ToArray());

                counter += 2 * k;
            }

            return Result;
        }
        public static string Reverse(string s)
        {
            return new String(s.Reverse().ToArray());
        } 
    }
}
