using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class TheKWeakestRowsInAMatrix_1337_UnitTest
    {
        [TestMethod, Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_mat = new int[][]
            {
                new int[]{1, 1, 0, 0, 0},
                new int[]{1, 1, 1, 1, 0},
                new int[]{1, 0, 0, 0, 0},
                new int[]{1, 1, 0, 0, 0},
                new int[]{1, 1, 1, 1, 1}
            };
            var Input_k = 3;
            var Expected = new int[] { 2, 0, 3 };
            var Actual = TheKWeakestRowsInAMatrix_1337.KWeakestRows(Input_mat, Input_k);
            CollectionAssert.AreEqual(Expected, Actual);

        }

    }
}
