using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MonotonicArray_896_UnitTest
    {
        [TestMethod, Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 2, 2, 3 };
            var Expected = true;
            var Actual = MonotonicArray_896.IsMonotonic(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 6, 5, 4, 4 };
            var Expected = true;
            var Actual = MonotonicArray_896.IsMonotonic(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 1, 3, 2 };
            var Expected = false;
            var Actual = MonotonicArray_896.IsMonotonic(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = new int[] { 1, 2, 4, 5 };
            var Expected = true;
            var Actual = MonotonicArray_896.IsMonotonic(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input = new int[] { 1, 1, 1 };
            var Expected = true;
            var Actual = MonotonicArray_896.IsMonotonic(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
