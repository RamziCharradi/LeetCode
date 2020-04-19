using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MinimumPathSum_64_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethd1()
        {
            var Input = new int[][]
            {
                new int[]{ 1, 3, 1 },
                new int[]{ 1, 5, 1 },
                new int[]{ 4, 2, 1 }
            };
            var Expected = 7;
            var Actual = MinimumPathSum_64.MinPathSum(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
