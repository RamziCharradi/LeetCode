using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ReverseLinkedList_206
    {
        public static ListNode ReverseList(ListNode head)
        {
            List<int> track = new List<int>();
            Helper(head,track);
            if (track.Count > 0)
            {
                int i = track.Count - 1;
                ListNode ReversedLinkedList = new ListNode(track[i--]);
                LinkedList(ref ReversedLinkedList.next, i,track);
                return ReversedLinkedList;
            }
            return null;
            
        }

        public static void Helper(ListNode node, List<int> l)
        {
            if(node!=null)
            {
                l.Add(node.val);
                Helper(node.next, l);
            }
            return;
        }

        public static void LinkedList(ref ListNode head,int counter, List<int> l)
        {
            if (counter>=0)
            {
                head = new ListNode(l[counter--]);
                if (counter >= 0) LinkedList(ref head.next, counter, l);
            }
            return;
        }
    }
}
