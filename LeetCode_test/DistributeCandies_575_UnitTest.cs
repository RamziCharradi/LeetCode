using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class DistributeCandies_575_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMthod1()
        {
            var Input = new int[] { 1, 1, 2, 2, 3, 3 };
            var Expected = 3;
            var Actual = DistributeCandies_575.DistributeCandies(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMthod2()
        {
            var Input = new int[] { 1, 1, 2, 3 };
            var Expected = 2;
            var Actual = DistributeCandies_575.DistributeCandies(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMthod3()
        {
            var Input = new int[] { 1, 1 };
            var Expected = 1;
            var Actual = DistributeCandies_575.DistributeCandies(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
