using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class DailyTemperatures_739_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var Expected = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };
            var Actual = DailyTemperatures_739.DailyTemperatures(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
