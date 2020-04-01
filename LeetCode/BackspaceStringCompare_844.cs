using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BackspaceStringCompare_844
    {
        public static bool BackspaceCompare(string S, string T)
        {
            Stack<char> Ss = new Stack<char>();
            foreach (var c in S)
            {
                if (!char.IsLetter(c))
                {
                    if (Ss.Count > 0) Ss.Pop();
                }
                else
                {
                    Ss.Push(c);
                }
            }
            Stack<char> St = new Stack<char>();
            foreach (var c in T)
            {
                if (!char.IsLetter(c))
                {
                    if (St.Count > 0) St.Pop();
                }
                else
                {
                    St.Push(c);
                }
            }

            return new String(Ss.ToArray()) == new String(St.ToArray());
        }

        //public static Stack<char> Helper(String input)
        //{
        //    Stack<char> S = new Stack<char>();

        //    foreach (var c in input)
        //    {
        //        if (!char.IsLetter(c))
        //        {
        //            if (S.Count > 0) S.Pop();
        //        }
        //        else
        //        {
        //            S.Push(c);
        //        }
        //    }
        //    return S;
        //}
    }
}
