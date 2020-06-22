using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MakeTwoArraysEqual_1460_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_target = new int[] { 1, 2, 3, 4 };
            var Input_arr = new int[] { 2, 4, 1, 3 };
            var Expected = true;
            var Actual = MakeTwoArraysEqual_1460.CanBeEqual(Input_target, Input_arr);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_target = new int[] { 7};
            var Input_arr = new int[] { 7 };
            var Expected = true;
            var Actual = MakeTwoArraysEqual_1460.CanBeEqual(Input_target, Input_arr);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_target = new int[] { 1, 12 };
            var Input_arr = new int[] { 12 , 1 };
            var Expected = true;
            var Actual = MakeTwoArraysEqual_1460.CanBeEqual(Input_target, Input_arr);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_target = new int[] { 3, 7, 9 };
            var Input_arr = new int[] { 3, 7, 11 };
            var Expected = false;
            var Actual = MakeTwoArraysEqual_1460.CanBeEqual(Input_target, Input_arr);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input_target = new int[] { 1, 1, 1, 1, 1 };
            var Input_arr = new int[] { 1, 1, 1, 1, 1 };
            var Expected = true;
            var Actual = MakeTwoArraysEqual_1460.CanBeEqual(Input_target, Input_arr);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
