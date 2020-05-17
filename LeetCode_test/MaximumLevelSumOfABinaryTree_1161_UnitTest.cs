using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LeetCode_test
{
    [TestClass]
    public class MaximumLevelSumOfABinaryTree_1161_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMthod1()
        {
            var Input = new TreeNode(1)
            {
                left = new TreeNode(7)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(-8)
                },
                right = new TreeNode(0)
            };
            var Expected = 2;
            var Actual = MaximumLevelSumOfABinaryTree_1161.MaxLevelSum(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
