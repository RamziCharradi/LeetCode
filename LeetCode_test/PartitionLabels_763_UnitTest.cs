using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class PartitionLabels_763_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMthod1()
        {
            var Input = "ababcbacadefegdehijhklij";
            IList<int> Expected = new List<int>() { 9, 7, 8 };
            var Actual = PartitionLabels_763.PartitionLabels(Input);
            CollectionAssert.AreEqual(Expected.ToArray(), Actual.ToArray());

        }
    }
}
