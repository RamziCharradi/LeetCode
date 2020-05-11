using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class SqrtX_69_TestUnit
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = 4;
            var Expected = 2;
            var Actual = SqrtX_69.MySqrt(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Input = 8;
            var Expected = 2;
            var Actual = SqrtX_69.MySqrt(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
