using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ReverseStringII_547_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_s = "abcdefg";
            var Input_k = 2;
            var Expected = "bacdfeg";
            var Actual = ReverseStringII_547.ReverseStr(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
