using LeetCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_test.Helpers
{
    internal static class Helper<T>
    {
        public static bool HaveSameInorderSequenceForTwoTreeNodes(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null || node1 == node2) return true;

            var s1 = new Stack<TreeNode>();
            var s2 = new Stack<TreeNode>();
            var curr1 = node1;
            var curr2 = node2;

            try
            {
                while ((curr1 != null || s1.Count != 0) && (curr2 != null || s2.Count != 0))
                {
                    while (curr1 != null || curr2 != null)
                    {
                        s1.Push(curr1);
                        curr1 = curr1.left;
                        s2.Push(curr2);
                        curr2 = curr2.left;
                    }
                    curr1 = s1.Peek();
                    curr2 = s2.Peek();
                    s1.Pop();
                    s2.Pop();

                    if (curr1.val != curr2.val) return false;

                    curr1 = curr1.right;
                    curr2 = curr2.right;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

    }
}
