using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ConsecutiveCharacters_1446_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "leetcode";
            var Expected = 2;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = "abbcccddddeeeeedcba";
            var Expected = 5;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = "triplepillooooow";
            var Expected = 5;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = "hooraaaaaaaaaaay";
            var Expected = 11;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input = "tourist";
            var Expected = 1;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod6()
        {
            var Input = "cc";
            var Expected = 2;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod7()
        {
            var Input = "c";
            var Expected = 1;
            var Actual = ConsecutiveCharacters_1446.MaxPower(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
