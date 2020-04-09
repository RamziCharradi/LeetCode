using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveLinkedListElements_203
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            if (head.val == val)
                return RemoveElements(head.next, val);

            head.next = RemoveElements(head.next, val);

            return head;
        }

    }
}
