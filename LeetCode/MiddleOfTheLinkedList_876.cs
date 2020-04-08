using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MiddleOfTheLinkedList_876
    {
        public static ListNode MiddleNode(ListNode head)
        {
            var x = Deepth(head);
            return NthNode(ref head, x / 2, 0); 

        }
        public static int Deepth(ListNode head)
        {
            if (head == null) return 0;
            return 1 + Deepth(head.next);
        }

        public static ListNode NthNode(ref ListNode head,int n, int counter)
        {
            if (counter == n)
            {
                return head;
            }
            return NthNode(ref head.next, n, ++counter);
        }
    }
}
