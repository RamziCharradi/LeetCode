using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ReducingDishes_1402_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { -1, -8, 0, 5, -9 };
            var Expected = 14;
            var Actual = ReducingDishes_1402.MaxSatisfaction(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 4, 3, 2 };
            var Expected = 20;
            var Actual = ReducingDishes_1402.MaxSatisfaction(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new int[] { -1, -4, -5 };
            var Expected = 0;
            var Actual = ReducingDishes_1402.MaxSatisfaction(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = new int[] { -2, 5, -1, 0, 3, -3 };
            var Expected = 35;
            var Actual = ReducingDishes_1402.MaxSatisfaction(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
