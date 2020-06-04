using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class LetterTilePossibilities_1079_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "AAB";
            var Expected = 8;
            var Actual = LetterTilePossibilities_1079.NumTilePossibilities(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = "AAABBC";
            var Expected = 188;
            var Actual = LetterTilePossibilities_1079.NumTilePossibilities(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
