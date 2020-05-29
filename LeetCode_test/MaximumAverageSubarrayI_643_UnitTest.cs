using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MaximumAverageSubarrayI_643_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 12, -5, -6, 50, 3 };
            var Input_k = 4;
            var Expected = 12.75;
            var Actual = MaximumAverageSubarrayI_643.FindMaxAverage(Input, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
