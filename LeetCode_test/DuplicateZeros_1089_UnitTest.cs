using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class DuplicateZeros_1089_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            var Expected = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 };
            var Actual = DuplicateZeros_1089.DuplicateZeros(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 2, 3 };
            var Expected = new int[] { 1, 2, 3 };
            var Actual = DuplicateZeros_1089.DuplicateZeros(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

    }
}
