using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ShuffleTheArray_1470_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_nums = new int[] { 2, 5, 1, 3, 4, 7 };
            var Input_n = 3;
            var Expected = new int[] { 2, 3, 5, 4, 1, 7 };
            var Actual = ShuffleTheArray_1470.Shuffle(Input_nums, Input_n);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_nums = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            var Input_n = 4;
            var Expected = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 };
            var Actual = ShuffleTheArray_1470.Shuffle(Input_nums, Input_n);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_nums = new int[] { 1, 1, 2, 2 };
            var Input_n = 2;
            var Expected = new int[] { 1, 2, 1, 2 };
            var Actual = ShuffleTheArray_1470.Shuffle(Input_nums, Input_n);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
