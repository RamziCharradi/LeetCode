using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class FindAllDuplicatesInAnArray_442_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> Expected = new int[] { 2, 3 };
            var Actual = FindAllDuplicatesInAnArray_442.FindDuplicates(Input);
            CollectionAssert.AreEqual(Expected.ToArray(), Actual.ToArray());
        }
    }
}
