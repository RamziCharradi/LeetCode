using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class SortArrayByParity_905_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 3, 1, 2, 4 };
            var expected1 = new int[] { 2, 4, 3, 1 };
            var expected2 = new int[] { 4, 2, 3, 1 };
            var expected3 = new int[] { 2, 4, 1, 3 };
            var expected4 = new int[] { 4, 2, 1, 3 };

            var Actual = SortArrayByParity_905.SortArrayByParity(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected1,Actual)|| 
                          Enumerable.SequenceEqual(expected2, Actual)||
                          Enumerable.SequenceEqual(expected3, Actual)||
                          Enumerable.SequenceEqual(expected4, Actual));
        }
    }
}
