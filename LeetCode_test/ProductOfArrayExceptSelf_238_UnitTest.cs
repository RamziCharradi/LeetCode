using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ProductOfArrayExceptSelf_238_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 2, 3, 4 };
            var Expected = new int[] { 24, 12, 8, 6 };
            var Actual = ProductOfArrayExceptSelf_238.ProductExceptSelf(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

    }
}
