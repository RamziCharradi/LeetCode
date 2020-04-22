using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using LeetCode_test.Helpers;

namespace LeetCode_test
{
    [TestClass]
    public class ConstructBinarySearchTreeFromPreorderTraversal_1008_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 8, 5, 1, 7, 10, 12 };
            var Expected = new TreeNode(8)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(7)
                },
                right = new TreeNode(10)
                {
                    right = new TreeNode(12)
                }

            };
            var Actual = ConstructBinarySearchTreeFromPreorderTraversal_1008.BstFromPreorder(Input);
            Assert.IsTrue(Helper<int>.HaveSameInorderSequenceForTwoTreeNodes(Expected, Actual));

        }
    }
}
