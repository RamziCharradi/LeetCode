using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ShuffleString_1528
    {
        public string RestoreString(string s, int[] indices)
        {

            char[] ans = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                ans[indices[i]] = s[i];
            }

            return new String(ans);


        }
    }
}
