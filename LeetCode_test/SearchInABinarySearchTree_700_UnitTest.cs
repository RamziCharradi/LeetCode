using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using LeetCode_test.Helpers;

namespace LeetCode_test
{
    [TestClass]
    public class SearchInABinarySearchTree_700_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_root = new TreeNode(4)
            {
                left = new TreeNode(2) 
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
            };
            var Input_val = 2;
            var Expected = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };
            var Actual = SearchInABinarySearchTree_700.SearchBST(Input_root, Input_val);
            Assert.IsTrue(Helper<int>.HaveSameInorderSequenceForTwoTreeNodes(Expected, Actual));

        }

    }
}
