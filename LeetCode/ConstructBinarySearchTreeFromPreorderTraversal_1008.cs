using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ConstructBinarySearchTreeFromPreorderTraversal_1008
    {
        public static TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode root = new TreeNode(preorder[0]);

            for (int i = 1; i < preorder.Length ; i++)
            {
                Add2Tree(ref root, preorder[i]);
               
            }
            return root;
        }
        public static void Add2Tree(ref TreeNode root, int val)
        {
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                parent = current;
                current = current.val > val ? current.left : current.right;
            }

            if (parent.val > val)
                parent.left = new TreeNode(val);
            else
                parent.right = new TreeNode(val);
        }
    }
}
