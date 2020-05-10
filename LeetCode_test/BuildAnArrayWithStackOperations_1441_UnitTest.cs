using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class BuildAnArrayWithStackOperations_1441_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input_Target = new int[] { 1, 3 };
            var Input_N = 3;
            IList<string> Expected = new List<string>() { "Push", "Push", "Pop", "Push" };
            var Actual = BuildAnArrayWithStackOperations_1441.BuildArray(Input_Target, Input_N);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Input_Target = new int[] { 1, 2, 3 };
            var Input_N = 3;
            IList<string> Expected = new List<string>() { "Push", "Push", "Push" };
            var Actual = BuildAnArrayWithStackOperations_1441.BuildArray(Input_Target, Input_N);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var Input_Target = new int[] { 1 , 2 };
            var Input_N = 4;
            IList<string> Expected = new List<string>() { "Push", "Push" };
            var Actual = BuildAnArrayWithStackOperations_1441.BuildArray(Input_Target, Input_N);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var Input_Target = new int[] { 2, 3, 4 };
            var Input_N = 4;
            IList<string> Expected = new List<string>() { "Push", "Pop", "Push", "Push", "Push" };
            var Actual = BuildAnArrayWithStackOperations_1441.BuildArray(Input_Target, Input_N);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }
    }
}
