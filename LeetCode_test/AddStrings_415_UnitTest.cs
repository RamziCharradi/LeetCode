using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class AddStrings_415_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_nums1 = "205";
            var Input_Nums2 = "5";
            var Expected = "210";
            var Actual = AddStrings_415.AddStrings(Input_nums1, Input_Nums2);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
