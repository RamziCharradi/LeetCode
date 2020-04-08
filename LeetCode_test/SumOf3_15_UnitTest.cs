using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class SumOf3_15_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> Expected = new List<IList<int>>()
            {
                new List<int>{ -1, 0, 1 },
                new List<int>{ -1, -1, 2 }
            };
            var Actual = SumOf3_15.ThreeSum(Input);

            Assert.AreEqual(Expected.Count, Actual.Count);
            for (var i = 0; i < Expected.Count; i++)
            {
                Assert.AreEqual(Expected[i].Count, Actual[i].Count);
                for (var j = 0; j < Expected[i].Count; j++)
                {
                    Assert.AreEqual(Expected[i][j], Actual[i][j]);
                }
            }
        } 
    }
}
