using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class NumberComplement_476_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 5;
            var Expected = 2;
            var Actual = NumberComplement_476.FindComplement(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
