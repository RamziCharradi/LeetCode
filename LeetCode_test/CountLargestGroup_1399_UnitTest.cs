using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class CountLargestGroup_1399_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 13;
            var Expected = 4;
            var Actual = CountLargestGroup_1399.CountLargestGroup(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = 2;
            var Expected = 2;
            var Actual = CountLargestGroup_1399.CountLargestGroup(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = 15;
            var Expected = 6;
            var Actual = CountLargestGroup_1399.CountLargestGroup(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = 24;
            var Expected = 5;
            var Actual = CountLargestGroup_1399.CountLargestGroup(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
