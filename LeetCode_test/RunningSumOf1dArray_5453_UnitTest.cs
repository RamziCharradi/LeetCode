using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RunningSumOf1dArray_5453_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void Testmethod1()
        {
            var Input = new int[] { 1, 2, 3, 4 };
            var Expected = new int[] { 1, 3, 6, 10 };
            var Actual = RunningSumOf1dArray_5453.RunningSum(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void Testmethod2()
        {
            var Input = new int[] { 1, 1, 1, 1, 1 };
            var Expected = new int[] { 1, 2, 3, 4, 5 };
            var Actual = RunningSumOf1dArray_5453.RunningSum(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void Testmethod3()
        {
            var Input = new int[] { 3, 1, 2, 10, 1 };
            var Expected = new int[] { 3, 4, 6, 16, 17 };
            var Actual = RunningSumOf1dArray_5453.RunningSum(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
