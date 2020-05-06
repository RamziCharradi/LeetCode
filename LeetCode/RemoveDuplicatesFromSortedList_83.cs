using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedList_83
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var root = head;
            while (head != null)
            {

                var pre = head;

                while (head != null && head.val == pre.val)
                {
                    head = head.next;
                    pre.next = head;
                }

            }
            return root;
        }
    }
}
