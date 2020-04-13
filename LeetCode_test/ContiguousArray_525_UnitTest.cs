using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ContiguousArray_525_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 0, 1 };
            var Expected = 2;
            var Actual = ContiguousArray_525.FindMaxLength(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 0, 0, 0, 1, 1, 1, 0 };
            var Expected = 6;
            var Actual = ContiguousArray_525.FindMaxLength(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 0, 0, 1, 1,};
            var Expected = 4;
            var Actual = ContiguousArray_525.FindMaxLength(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
