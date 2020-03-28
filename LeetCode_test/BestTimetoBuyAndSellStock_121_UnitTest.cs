using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class BestTimetoBuyAndSellStock_121_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            var expected = 5;
            var actual = BestTimetoBuyAndSellStock_121.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 7, 6, 4, 3, 1 };
            var expected = 0;
            var actual = BestTimetoBuyAndSellStock_121.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
