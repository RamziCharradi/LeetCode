using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class QueriesOnAPermutationWithKey_1409_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_queries = new int[] { 3, 1, 2, 1 };
            var Input_m = 5;
            var Expected = new int[] { 2, 1, 2, 1 };
            var Actual = QueriesOnAPermutationWithKey_1409.ProcessQueries(Input_queries, Input_m);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_queries = new int[] { 4, 1, 2, 2 };
            var Input_m = 4;
            var Expected = new int[] { 3, 1, 2, 0 };
            var Actual = QueriesOnAPermutationWithKey_1409.ProcessQueries(Input_queries, Input_m);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_queries = new int[] { 7, 5, 5, 8, 3 };
            var Input_m = 8;
            var Expected = new int[] { 6, 5, 0, 7, 5 };
            var Actual = QueriesOnAPermutationWithKey_1409.ProcessQueries(Input_queries, Input_m);
            CollectionAssert.AreEqual(Expected, Actual);
        }

    }
}
