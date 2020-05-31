using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466_UnitTest
    {
        [TestMethod, Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_n = 6;
            var Input_connections = new int[][]
            {
                new int[]{0,1},
                new int[]{1,3},
                new int[]{2,3},
                new int[]{4,0},
                new int[]{4,5}
            };
            var Expected = 3;
            var Actual = ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466.MinReorder(Input_n, Input_connections);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_n = 5;
            var Input_connections = new int[][]
            {
                // [[1,0],[1,2],[3,2],[3,4]]
                new int[]{1,0},
                new int[]{1,2},
                new int[]{3,2},
                new int[]{3,4}
            };
            var Expected = 2;
            var Actual = ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466.MinReorder(Input_n, Input_connections);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_n = 3;
            var Input_connections = new int[][]
            {
                // [[1,0],[2,0]]
                new int[]{1,0},
                new int[]{2,0}
            };
            var Expected = 0;
            var Actual = ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466.MinReorder(Input_n, Input_connections);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_n = 5;
            var Input_connections = new int[][]
            {
                // [[1,0],[1,2],[2,3],[4,2]]
                new int[]{1,0},
                new int[]{1,2},
                new int[]{2,3},
                new int[]{4,2}
            };
            var Expected = 2;
            var Actual = ReorderRoutesToMakeAllPathsLeadToTheCityZero_1466.MinReorder(Input_n, Input_connections);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
