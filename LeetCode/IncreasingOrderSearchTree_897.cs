using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class IncreasingOrderSearchTree_897
    {
        public static TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode output = null, current = null;
            Helper(root, ref output, ref current);
            return output;

        }
        private static void Helper(TreeNode inputNode, ref TreeNode outputRoot, ref TreeNode outputCurrent)
        {
            if (inputNode == null)
            {
                return;
            }

            Helper(inputNode.left, ref outputRoot, ref outputCurrent);

            if (outputRoot == null)
            {
                outputRoot = new TreeNode(inputNode.val);
                outputCurrent = outputRoot;
            }
            else
            {
                outputCurrent.right = new TreeNode(inputNode.val);
                outputCurrent = outputCurrent.right;
            }

            Helper(inputNode.right, ref outputRoot, ref outputCurrent);
        }

       
    }
}
