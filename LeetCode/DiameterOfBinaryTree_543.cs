using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DiameterOfBinaryTree_543
    {
        private static int Result;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            Result = 0;
            MaxDepth(root);
            return Result;
        }
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            Result = Math.Max(left + right, Result);
            return Math.Max(left, right) + 1;
        }
    }
}
