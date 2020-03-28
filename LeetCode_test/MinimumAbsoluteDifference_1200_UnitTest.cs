using LeetCode;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class MinimumAbsoluteDifference_1200_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] {4, 2, 1, 3};
            IList<IList<int>> expected = new List<IList<int>>()
            {   new List<int>() { 1, 2 },
                new List<int>() { 2, 3 }, 
                new List<int>() { 3, 4 } 
            };
            var actual = MinimumAbsoluteDifference_1200.MinimumAbsDifference(input);
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (var j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 3, 6, 10, 15 };
            IList<IList<int>> expected = new List<IList<int>>(){ new List<int>() { 1, 3 } };
            var actual = MinimumAbsoluteDifference_1200.MinimumAbsDifference(input);
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (var j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 3, 8, -10, 23, 19, -4, -14, 27 };
            IList<IList<int>> expected = new List<IList<int>>()
            {   new List<int>() { -14,-10 },
                new List<int>() { 19,23 },
                new List<int>() { 23,27 }
            };
            var actual = MinimumAbsoluteDifference_1200.MinimumAbsDifference(input);
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count);
                for (var j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

    }
}
