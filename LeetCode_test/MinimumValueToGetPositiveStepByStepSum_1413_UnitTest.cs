using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;


namespace LeetCode_test
{
    [TestClass]
    public class MinimumValueToGetPositiveStepByStepSum_1413_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { -3, 2, -3, 4, 2 };
            var Expected = 5;
            var Actual = MinimumValueToGetPositiveStepByStepSum_1413.MinStartValue(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 2 };
            var Expected = 1;
            var Actual = MinimumValueToGetPositiveStepByStepSum_1413.MinStartValue(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 1, -2, -3 };
            var Expected = 5;
            var Actual = MinimumValueToGetPositiveStepByStepSum_1413.MinStartValue(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
