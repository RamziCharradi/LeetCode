using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class FinalPricesWithASpecialDiscountInAShop_1475_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 8, 4, 6, 2, 3 };
            var Expected = new int[] { 4, 2, 4, 2, 3 };
            var Actual = FinalPricesWithASpecialDiscountInAShop_1475.FinalPrices(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 1, 2, 3, 4, 5 };
            var Expected = new int[] { 1, 2, 3, 4, 5 };
            var Actual = FinalPricesWithASpecialDiscountInAShop_1475.FinalPrices(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 10, 1, 1, 6 };
            var Expected = new int[] { 9, 0, 1, 6 };
            var Actual = FinalPricesWithASpecialDiscountInAShop_1475.FinalPrices(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
