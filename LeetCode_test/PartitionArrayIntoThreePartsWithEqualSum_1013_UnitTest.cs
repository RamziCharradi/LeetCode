using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class PartitionArrayIntoThreePartsWithEqualSum_1013_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 };
            var Expected = true;
            var Actual = PartitionArrayIntoThreePartsWithEqualSum_1013.CanThreePartsEqualSum(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 };
            var Expected = false;
            var Actual = PartitionArrayIntoThreePartsWithEqualSum_1013.CanThreePartsEqualSum(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 };
            var Expected = true;
            var Actual = PartitionArrayIntoThreePartsWithEqualSum_1013.CanThreePartsEqualSum(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input = new int[] { 18, 12, -18, 18, -19, -1, 10, 10 };
            var Expected = true;
            var Actual = PartitionArrayIntoThreePartsWithEqualSum_1013.CanThreePartsEqualSum(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
