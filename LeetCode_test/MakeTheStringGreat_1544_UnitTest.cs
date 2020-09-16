using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MakeTheStringGreat_1544_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "leEeetcode";
            var Expected = "leetcode";
            var Actual = MakeTheStringGreat_1544.MakeGood(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
