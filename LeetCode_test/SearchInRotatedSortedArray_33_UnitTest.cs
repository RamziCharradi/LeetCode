using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class SearchInRotatedSortedArray_33_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var Input_target = 0;
            var Expected = 4;
            var Actual = SearchInRotatedSortedArray_33.Search(Input_nums, Input_target);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var Input_target = 3;
            var Expected = -1;
            var Actual = SearchInRotatedSortedArray_33.Search(Input_nums, Input_target);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
