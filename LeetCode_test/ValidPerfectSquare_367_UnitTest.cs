using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ValidPerfectSquare_367_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = 16;
            var Expected = true;
            var Actual = ValidPerfectSquare_367.IsPerfectSquare(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Input = 14;
            var Expected = false;
            var Actual = ValidPerfectSquare_367.IsPerfectSquare(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
