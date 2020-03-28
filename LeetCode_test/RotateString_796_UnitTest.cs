using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RotateString_796_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_A = "abcde";
            var Input_B = "cdeab";
            var Expected = true;
            var Actual = RotateString_796.RotateString(Input_A, Input_B);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_A = "abcde";
            var Input_B = "abced";
            var Expected = false;
            var Actual = RotateString_796.RotateString(Input_A, Input_B);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
