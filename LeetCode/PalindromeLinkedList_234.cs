using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class PalindromeLinkedList_234
    {
        public static bool IsPalindrome(ListNode head)
        {
            List<object> l = new List<object>() {};
            Stack<object> stk = new Stack<object>();
            while (head != null)
            {
                stk.Push(head.val);
                l.Add(head.val);
                head = head.next;
            }

            return l.SequenceEqual(stk.ToList());
            //return l.SequenceEqual(l.Select(x => x).Reverse());
        }
    }
}
