using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchInABinarySearchTree_700
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null)
            {
                if (root == null || (root.val == val))
                    return root;
                else if (root.val < val)
                    root = root.right;
                else root = root.left;
            }

            return root;
        }
    }
}
