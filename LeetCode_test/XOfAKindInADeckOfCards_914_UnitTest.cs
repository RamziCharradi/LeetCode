using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class XOfAKindInADeckOfCards_914_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        [DataRow(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 },true)]
        [DataRow(new int[] { 1, 1, 1, 2, 2, 2, 3, 3 }, false)]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { 1, 1 }, true)]
        [DataRow(new int[] { 1, 1, 2, 2, 2, 2 }, true)]
        [DataRow(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 2, 2 },true)]
        public void TestMethod1(int[] Input, bool Expected)
        {
            var Actual = XOfAKindInADeckOfCards_914.HasGroupsSizeX(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
