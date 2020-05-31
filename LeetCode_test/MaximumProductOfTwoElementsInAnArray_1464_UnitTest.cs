using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MaximumProductOfTwoElementsInAnArray_1464_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 3, 4, 5, 2 };
            var Expected = 12;
            var Actual = MaximumProductOfTwoElementsInAnArray_1464.MaxProduct(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 5, 4, 5 };
            var Expected = 16;
            var Actual = MaximumProductOfTwoElementsInAnArray_1464.MaxProduct(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 3 , 7 };
            var Expected = 12;
            var Actual = MaximumProductOfTwoElementsInAnArray_1464.MaxProduct(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
