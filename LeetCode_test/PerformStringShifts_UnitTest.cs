using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class PerformStringShifts_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_S = "abc";
            var Input_Shift = new int[][] { new int[]{ 0, 1 }, new int[] { 1, 2 } };
            var Expected = "cab";
            var Actual = PerformStringShifts.StringShift(Input_S, Input_Shift);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
