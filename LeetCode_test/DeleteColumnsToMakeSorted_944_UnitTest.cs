using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class DeleteColumnsToMakeSorted_944_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new string[] { "cba", "daf", "ghi" };
            var Expected = 1;
            var Actual = DeleteColumnsToMakeSorted_944.MinDeletionSize(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new string[] { "a", "b" };
            var Expected = 0;
            var Actual = DeleteColumnsToMakeSorted_944.MinDeletionSize(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new string[] { "zyx", "wvu", "tsr" };
            var Expected = 3;
            var Actual = DeleteColumnsToMakeSorted_944.MinDeletionSize(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
