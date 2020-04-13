using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class TwoSumII_167_UnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_Array = new int[] { 2, 7, 11, 15 };
            var Input_Target = 9;
            var Expected = new int[] { 1, 2 };
            var Actual = TwoSumII_167.TwoSum(Input_Array, Input_Target);
            CollectionAssert.AreEqual(Expected, Actual);

        }
    }
}
