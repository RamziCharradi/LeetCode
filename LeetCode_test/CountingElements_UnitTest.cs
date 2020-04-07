using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class CountingElements_UnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 2, 3 };
            var Expected = 2;
            var Actual = CountingElements.CountElements(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 1, 3, 3, 5, 5, 7, 7 };
            var Expected = 0;
            var Actual = CountingElements.CountElements(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 1, 3, 2, 3, 5, 0 };
            var Expected = 3;
            var Actual = CountingElements.CountElements(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input = new int[] { 1, 1, 2, 2 };
            var Expected = 2;
            var Actual = CountingElements.CountElements(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
