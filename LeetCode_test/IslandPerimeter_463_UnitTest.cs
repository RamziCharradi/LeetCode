using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class IslandPerimeter_463_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[][]
            {
                new int[]{0,1,0,0},
                new int[]{1,1,1,0},
                new int[]{0,1,0,0},
                new int[]{ 1, 1, 0, 0 }
            };
            var Expected = 16;
            var Actual = IslandPerimeter_463.IslandPerimeter(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
