using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using LeetCode_test.Helpers;

namespace LeetCode_test
{
    [TestClass]
    public class IncreasingOrderSearchTree_897_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(8)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(9)
                    }
                }
            };
            var Expected = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    right = new TreeNode(3)
                    {
                        right = new TreeNode(4)
                        {
                            right = new TreeNode(5)
                            {
                                right = new TreeNode(6)
                                {
                                    right = new TreeNode(7)
                                    {
                                        right = new TreeNode(8)
                                        {
                                            right = new TreeNode(9)

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            var Actual = IncreasingOrderSearchTree_897.IncreasingBST(Input);
            Assert.IsTrue(Helper<int>.HaveSameInorderSequenceForTwoTreeNodes(Expected, Actual));

        }
    }
}
