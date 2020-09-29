using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MinCostClimbingStairs_746_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var input = new int[] { 10, 15, 20 };
            var Expected = 15;
            var Actual = MinCostClimbingStairs_746.MinCostClimbingStairs(input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var Expected = 6;
            var Actual = MinCostClimbingStairs_746.MinCostClimbingStairs(input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
