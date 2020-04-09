using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class SearchInsertPosition_35_UnitTest
    {
        [TestMethod]
        public void MethodTest1()
        {
            var Input_Nums = new int[] { 1, 3, 5, 6 };
            var Input_Target = 5;
            var Expected = 2;
            var Actual = SearchInsertPosition_35.SearchInsert(Input_Nums, Input_Target);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void MethodTest2()
        {
            var Input_Nums = new int[] { 1, 3, 5, 6 };
            var Input_Target = 2;
            var Expected = 1;
            var Actual = SearchInsertPosition_35.SearchInsert(Input_Nums, Input_Target);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void MethodTest3()
        {
            var Input_Nums = new int[] { 1, 3, 5, 6 };
            var Input_Target = 7;
            var Expected = 4;
            var Actual = SearchInsertPosition_35.SearchInsert(Input_Nums, Input_Target);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void MethodTest4()
        {
            var Input_Nums = new int[] { 1, 3, 5, 6 };
            var Input_Target = 0;
            var Expected = 0;
            var Actual = SearchInsertPosition_35.SearchInsert(Input_Nums, Input_Target);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
