using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class NextGreaterElementI_496_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_nums1 = new int[] { 4, 1, 2 };
            var Input_nums2 = new int[] { 1, 3, 4, 2 };
            var Expected = new int[] { -1, 3, -1 };
            var Actual = NextGreaterElementI_496.NextGreaterElement(Input_nums1, Input_nums2);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_nums1 = new int[] { 2, 4 };
            var Input_nums2 = new int[] { 1, 2, 3, 4 };
            var Expected = new int[] { 3, -1 };
            var Actual = NextGreaterElementI_496.NextGreaterElement(Input_nums1, Input_nums2);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_nums1 = new int[] { 1, 3, 5, 2, 4 };
            var Input_nums2 = new int[] { 6, 5, 4, 3, 2, 1, 7 };
            var Expected = new int[] { 7, 7, 7, 7, 7 };
            var Actual = NextGreaterElementI_496.NextGreaterElement(Input_nums1, Input_nums2);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
