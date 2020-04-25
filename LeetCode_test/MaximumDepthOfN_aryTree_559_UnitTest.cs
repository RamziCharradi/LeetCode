using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MaximumDepthOfN_aryTree_559_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = new Node(1)
            {
                children = new List<Node>
                {
                   new Node(3)
                   {
                       children = new List<Node>
                       {
                           new Node(5),
                           new Node(6)
                       }
                   },
                   new Node(2),
                   new Node(4)
                }
            };

            var Expected = 3;
            var Actual = MaximumDepthOfN_aryTree_559.MaxDepth(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
