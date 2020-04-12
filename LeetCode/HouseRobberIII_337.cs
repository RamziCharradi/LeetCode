using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HouseRobberIII_337
    {
        public static int Rob(TreeNode root)
        {
            return RobUtil(root)[0];

        }

        public static int[] RobUtil(TreeNode root)
        {
            if (root == null) return new int[2];

            int max = root.val;
            int noRob = 0;

            int[] leftDp = RobUtil(root.left);
            int[] rightDp = RobUtil(root.right);

            max += leftDp[1] + rightDp[1];
            noRob += leftDp[0] + rightDp[0];

            return new int[] { Math.Max(max, noRob), noRob };
        }
    }
}
