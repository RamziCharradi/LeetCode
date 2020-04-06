using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public  class LastStoneWeight_1046_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 2, 7, 4, 1, 8, 1 };
            var Expected = 1;
            var Actual = LastStoneWeight_1046.LastStoneWeight(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
