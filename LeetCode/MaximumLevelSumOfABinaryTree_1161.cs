using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MaximumLevelSumOfABinaryTree_1161
    {
        static Dictionary<int, int> d = new Dictionary<int, int>();
        static int level = 0;

        public static int MaxLevelSum(TreeNode root)
        {
            level++;

            if (root != null)
            {
                if (d.ContainsKey(level)) d[level] += root.val;
                else d.Add(level, root.val);
            }
            
            if (root.left != null) MaxLevelSum(root.left);
            if (root.right != null) MaxLevelSum(root.right);

            return d.Where(x => x.Value == d.Max(x => x.Value)).Select(x=>x.Key).OrderBy(x=>x).FirstOrDefault();
        }
 
    }
}
