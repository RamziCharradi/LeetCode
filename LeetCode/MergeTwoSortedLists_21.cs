using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeTwoSortedLists_21
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode Result = new ListNode(Math.Min(l1.val, l2.val));
            if (l1.val < l2.val)
            {
                LinkedList(ref Result,  l1.next,  l2);
            }
            else
            {
                LinkedList(ref Result,  l1,  l2.next);
            }

            return Result;
        }
 

        public static void LinkedList(ref ListNode head, ListNode l1, ListNode l2)
        {
            if(l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    head.next = new ListNode(l1.val);
                    LinkedList(ref head.next, l1.next, l2);
                }
                else if (l2.val < l1.val)
                {
                    head.next = new ListNode(l2.val);
                    LinkedList(ref head.next, l1, l2.next);
                }
            }
            else
            {
                if (l1 != null) 
                {
                    head.next = new ListNode(l1.val);
                    LinkedList(ref head.next, l1.next, l2);
                } 
                if (l2 != null)
                {
                    head.next = new ListNode(l2.val);
                    LinkedList(ref head.next, l1, l2.next);
                }
            }
          
        }

    }
}
