using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RevealCardsInIncreasingOrder_950_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 17, 13, 11, 2, 3, 5, 7 };
            var Expected = new int[] { 2, 13, 3, 11, 5, 17, 7 };
            var Actual = RevealCardsInIncreasingOrder_950.DeckRevealedIncreasing(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
