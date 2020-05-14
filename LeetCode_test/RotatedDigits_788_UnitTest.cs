using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RotatedDigits_788_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 10;
            var Expected = 4;
            var Actual = RotatedDigits_788.RotatedDigits(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
