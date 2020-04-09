using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArray_26_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 1, 2 };
            var Expected = 2;
            var Actual = RemoveDuplicatesFromSortedArray_26.RemoveDuplicates(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var Expected = 5;
            var Actual = RemoveDuplicatesFromSortedArray_26.RemoveDuplicates(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
