using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace LeetCode_test
{
    [TestClass]
    public class FindTheDistanceValueBetweenTwoArrays_1385_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_arr1 = new int[] { 4, 5, 8 };
            var Input_arr2 = new int[] { 10, 9, 1, 8 };
            var Input_d = 2;
            var Expected = 2;
            var Actual = FindTheDistanceValueBetweenTwoArrays_1385.FindTheDistanceValue(Input_arr1, Input_arr2,Input_d);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_arr1 = new int[] { 2, 1, 100, 3 };
            var Input_arr2 = new int[] { -5, -2, 10, -3, 7 };
            var Input_d = 6;
            var Expected = 1;
            var Actual = FindTheDistanceValueBetweenTwoArrays_1385.FindTheDistanceValue(Input_arr1, Input_arr2, Input_d);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input_arr1 = new int[] { 1, 4, 2, 3 };
            var Input_arr2 = new int[] { -4, -3, 6, 10, 20, 30 };
            var Input_d = 3;
            var Expected = 2;
            var Actual = FindTheDistanceValueBetweenTwoArrays_1385.FindTheDistanceValue(Input_arr1, Input_arr2, Input_d);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
