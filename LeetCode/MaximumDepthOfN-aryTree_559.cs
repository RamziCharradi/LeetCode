using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaximumDepthOfN_aryTree_559
    {
        public static int MaxDepth(Node root)
        {

            if (root == null) return 0;

            int m = 0;

            if (root.children == null) return 1+ m;

            foreach (var node in root.children)
            {
                var k = MaxDepth(node);
                if (k >= m) m = k;
            }

            return 1 + m;
        }
    }
}
