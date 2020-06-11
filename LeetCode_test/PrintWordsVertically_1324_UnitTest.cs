using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class PrintWordsVertically_1324_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "HOW ARE YOU";
            IList<string> Expected = new string[] { "HAY", "ORO", "WEU" };
            var Actual = PrintWordsVertically_1324.PrintVertically(Input);
            CollectionAssert.AreEqual(Expected.ToArray(), Actual.ToArray());
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = "TO BE OR NOT TO BE";
            IList<string> Expected = new string[] { "TBONTB", "OEROOE", "   T" };
            var Actual = PrintWordsVertically_1324.PrintVertically(Input);
            CollectionAssert.AreEqual(Expected.ToArray(), Actual.ToArray());
        }
    }
}
