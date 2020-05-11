using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class SumOfSquareNumbers_633_UnitTest
    {
        [TestMethod]
        public void TestMthod1()
        {
            var Input = 5;
            var Expected = true;
            var Actual = SumOfSquareNumbers_633.JudgeSquareSum(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMthod2()
        {
            var Input = 3;
            var Expected = false;
            var Actual = SumOfSquareNumbers_633.JudgeSquareSum(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
