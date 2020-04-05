using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class CountNumberOfTeams_1395_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 2, 5, 3, 4, 1 };
            var Expected = 3;
            var Actual = CountNumberOfTeams_1395.NumTeams(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 2, 1, 3 };
            var Expected = 0;
            var Actual = CountNumberOfTeams_1395.NumTeams(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 1, 2, 3, 4 };
            var Expected = 4;
            var Actual = CountNumberOfTeams_1395.NumTeams(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
