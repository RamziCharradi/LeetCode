using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class CountPrimes_204_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 10;
            var Expected = 4;
            var Actual = CountPrimes_204.CountPrimes(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
