using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class NextGreaterElementII_503_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 1, 2, 1 };
            var Expected = new int[] { 2, -1, 2 };
            var Actual = NextGreaterElementII_503.NextGreaterElements(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

    }
}
