using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class HouseRobber_198_UnitTest
    {
        [TestMethod,Timeout(5_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 2, 3, 1 };
            var Expected = 4;
            var Actual = HouseRobber_198.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(5_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 2, 7, 9, 3, 1 };
            var Expected = 12;
            var Actual = HouseRobber_198.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(5_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 2, 1, 1, 2 };
            var Expected = 4;
            var Actual = HouseRobber_198.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
