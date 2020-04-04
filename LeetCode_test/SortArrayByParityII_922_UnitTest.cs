using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{ 
    [TestClass]
    public class SortArrayByParityII_922_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 4, 2, 5, 7 };
            var Expected = new int[] { 4, 5, 2, 7 };
            var Actual = SortArrayByParityII_922.SortArrayByParityII(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

    }
}
