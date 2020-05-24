using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LeetCode_test
{
    [TestClass]
    public class AllPathsFromSourceToTarget_797_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[][]
            {
                new int[]{1,2},
                new int[]{3},
                new int[]{3},
                new int[]{}
            };

            var Expected = new int[][]
            {
                new int[]{0,1,3},
                new int[]{0,2,3}
            };
            var Actual = AllPathsFromSourceToTarget_797.AllPathsSourceTarget(Input);

            Assert.AreEqual(Expected.Length, Actual.Count);
            for (int i = 0; i < Expected.Length; i++)
            {
                CollectionAssert.AreEqual(Expected[i], Actual.ToArray()[i].ToArray());
            }

        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            //[[4,3,1],[3,2,4],[3],[4],[]]
            var Input = new int[][]
            {
                new int[]{4,3,1},
                new int[]{3,2,4},
                new int[]{3},
                new int[]{4},
                new int[]{}
            };
            //[[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
            var Expected = new int[][]
            {
                new int[]{0,4},
                new int[]{0,3,4},
                new int[]{0,1,3,4},
                new int[]{0,1,2,3,4},
                new int[]{0,1,4}
            };
            var Actual = AllPathsFromSourceToTarget_797.AllPathsSourceTarget(Input);

            Assert.AreEqual(Expected.Length, Actual.Count);
            for (int i = 0; i < Expected.Length; i++)
            {
                CollectionAssert.AreEqual(Expected[i], Actual.ToArray()[i].ToArray());
            }

        }
    }
}
