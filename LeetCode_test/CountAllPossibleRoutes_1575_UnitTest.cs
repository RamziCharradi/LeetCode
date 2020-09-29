using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class CountAllPossibleRoutes_1575_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_locations = new int[] { 2, 3, 6, 8, 4 };
            var Input_start = 1;
            var Input_finish = 3;
            var Input_fuel = 5;
            var Expected = 4;
            var Actual = CountAllPossibleRoutes_1575.CountRoutes(Input_locations, Input_start, Input_finish, Input_fuel);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_locations = new int[] { 4, 3, 1 };
            var Input_start = 1;
            var Input_finish = 0;
            var Input_fuel = 6;
            var Expected = 5;
            var Actual = CountAllPossibleRoutes_1575.CountRoutes(Input_locations, Input_start, Input_finish, Input_fuel);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_locations = new int[] { 5, 2, 1 };
            var Input_start = 0;
            var Input_finish = 2;
            var Input_fuel = 3;
            var Expected = 0;
            var Actual = CountAllPossibleRoutes_1575.CountRoutes(Input_locations, Input_start, Input_finish, Input_fuel);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_locations = new int[] { 1, 2, 3 };
            var Input_start = 0;
            var Input_finish = 2;
            var Input_fuel = 40;
            var Expected = 615088286;
            var Actual = CountAllPossibleRoutes_1575.CountRoutes(Input_locations, Input_start, Input_finish, Input_fuel);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
