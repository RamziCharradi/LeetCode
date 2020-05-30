using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ShortestUnsortedContinuousSubarray_581_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 2, 6, 4, 8, 10, 9, 15 };
            var Expected = 5;
            var Actual = ShortestUnsortedContinuousSubarray_581.FindUnsortedSubarray(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
