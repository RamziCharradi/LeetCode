using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class LetterCasePermutation_784_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = "a1b2";
            IList<string> Expected = new List<string>() { "a1b2", "a1B2", "A1b2", "A1B2" };
            var Actual = LetterCasePermutation_784.LetterCasePermutation(Input);
            Assert.AreEqual(Expected.Count, Actual.Count);
            for (var i = 0; i < Expected.Count; i++)
            {
                Assert.AreEqual(Expected[i], Actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = "3z4";
            IList<string> Expected = new List<string>() { "3z4", "3Z4" };
            var Actual = LetterCasePermutation_784.LetterCasePermutation(Input);
            Assert.AreEqual(Expected.Count, Actual.Count);
            for (var i = 0; i < Expected.Count; i++)
            {
                Assert.AreEqual(Expected[i], Actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = "12345";
            IList<string> Expected = new List<string>() { "12345" };
            var Actual = LetterCasePermutation_784.LetterCasePermutation(Input);
            Assert.AreEqual(Expected.Count, Actual.Count);
            for (var i = 0; i < Expected.Count; i++)
            {
                Assert.AreEqual(Expected[i], Actual[i]);
            }
        }
    }
}
