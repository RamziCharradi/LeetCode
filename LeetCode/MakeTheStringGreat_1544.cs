using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class MakeTheStringGreat_1544
    {
        public static string MakeGood(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (var c in s)
            {
                if (st.Count == 0) st.Push(c);
                else
                {
                    if(char.ToLower(c) == char.ToLower(st.Peek()))
                    {
                        if (c != st.Peek()) st.Pop();
                        else st.Push(c);
                    }
                    else
                    {
                        st.Push(c);
                    }
                }
            }
            return new String(st.Reverse().ToArray());

        }
    }
}
