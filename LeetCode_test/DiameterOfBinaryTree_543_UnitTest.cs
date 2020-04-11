using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class DiameterOfBinaryTree_543_UnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };

            var Expected = 3;
            var Actual = DiameterOfBinaryTree_543.DiameterOfBinaryTree(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
