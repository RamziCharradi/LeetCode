using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class HouseRobberII_213_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 2, 3, 2 };
            var Expected = 3;
            var Actual = HouseRobberII_213.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 2, 3, 1 };
            var Expected = 4;
            var Actual = HouseRobberII_213.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 1, 2, 1, 1 };
            var Expected = 3;
            var Actual = HouseRobberII_213.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
