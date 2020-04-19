using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinimumAddToMakeParenthesesValid_921
    {
        public static int MinAddToMakeValid(string S)
        {
            Stack<char> st = new Stack<char>();

            foreach (var c in S)
            {
                if (st.Count == 0) st.Push(c);
                else if (st.Peek() == '(' && c == ')') st.Pop();
                else st.Push(c);
            }

            return st.Count;
        }
    }
}
