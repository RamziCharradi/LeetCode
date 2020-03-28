using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class RotateString_796
    {
        public static bool RotateString(string A, string B)
        {
            return A.Length == B.Length && (A+A).Contains(B);
        }
    }
}
