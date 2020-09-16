using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class SpecialPositionsInABinaryMatrix_1582_UnitTest
    {
       [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var input = new int[][]
            {
                new int[]{ 1, 0, 0 },
                new int[]{ 0, 0, 1 },
                new int[]{ 1, 0, 0 }
            };

            var Expected = 1;
            var Actual = SpecialPositionsInABinaryMatrix_1582.NumSpecial(input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var input = new int[][]
            {
                new int[]{0, 0 },
                new int[]{0 ,0 },
                new int[]{ 1, 0 }
            };

            var Expected = 1;
            var Actual = SpecialPositionsInABinaryMatrix_1582.NumSpecial(input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
