using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class FindTheTownJudge_997_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_N = 2;
            var Input_Trust = new int[][] { new int[] { 1, 2 } };
            var Expected = 2;
            var Actual = FindTheTownJudge_997.FindJudge(Input_N, Input_Trust);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_N = 3;
            var Input_Trust = new int[][] { new int[] { 1, 3 } , new int[] { 2, 3 } };
            var Expected = 3;
            var Actual = FindTheTownJudge_997.FindJudge(Input_N, Input_Trust);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input_N = 3;
            var Input_Trust = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 1 }
            };
            var Expected = -1;
            var Actual = FindTheTownJudge_997.FindJudge(Input_N, Input_Trust);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input_N = 3;
            var Input_Trust = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };
            var Expected = -1;
            var Actual = FindTheTownJudge_997.FindJudge(Input_N, Input_Trust);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var Input_N = 4;
            var Input_Trust = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 2, 4 },
                new int[] { 4, 3 }
            };
            var Expected = 3;
            var Actual = FindTheTownJudge_997.FindJudge(Input_N, Input_Trust);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
