using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class StringMatchingInAnArray_1408_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void Testmethod1()
        {
            var Input = new string[]{ "mass","as","hero","superhero"};
            IList<string> Expected = new List<string> { "as", "hero" };
            var Actual = StringMatchingInAnArray_1408.StringMatching(Input);
            CollectionAssert.AreEqual(Expected.ToArray(), Actual.ToArray());
        }
    }
}
