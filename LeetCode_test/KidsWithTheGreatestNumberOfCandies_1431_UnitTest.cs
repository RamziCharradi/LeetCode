using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class KidsWithTheGreatestNumberOfCandies_1431_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_candies = new int[] { 2, 3, 5, 1, 3 };
            var Input_extra = 3;
            IList<bool> Expected = new List<bool> { true, true, true, false, true };
            var Actual = KidsWithTheGreatestNumberOfCandies_1431.KidsWithCandies(Input_candies, Input_extra);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_candies = new int[] { 4, 2, 1, 1, 2 };
            var Input_extra = 1;
            IList<bool> Expected = new List<bool> { true, false, false, false, false };
            var Actual = KidsWithTheGreatestNumberOfCandies_1431.KidsWithCandies(Input_candies, Input_extra);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_candies = new int[] { 12, 1, 12 };
            var Input_extra = 10;
            IList<bool> Expected = new List<bool> { true, false, true };
            var Actual = KidsWithTheGreatestNumberOfCandies_1431.KidsWithCandies(Input_candies, Input_extra);
            CollectionAssert.AreEqual(Expected.ToList(), Actual.ToList());
        }

    }
}
