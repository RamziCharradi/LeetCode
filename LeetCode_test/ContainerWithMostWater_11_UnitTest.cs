using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ContainerWithMostWater_11_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var Expected = 49;
            var Actual = ContainerWithMostWater_11.MaxArea(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1,2 };
            var Expected = 1;
            var Actual = ContainerWithMostWater_11.MaxArea(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 2, 3, 4, 5, 18, 17, 6 };
            var Expected = 17;
            var Actual = ContainerWithMostWater_11.MaxArea(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
