using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class RomanToInteger_13_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMtheod1()
        {
            var Input = "III";
            var Expected = 3;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMtheod2()
        {
            var Input = "IV";
            var Expected = 4;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(2_000)]
        public void TestMtheod3()
        {
            var Input = "IX";
            var Expected = 9;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMtheod4()
        {
            var Input = "LVIII";
            var Expected = 58;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }


        [TestMethod, Timeout(2_000)]
        public void TestMtheod5()
        {
            var Input = "MCMXCIV";
            var Expected = 1994;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMtheod6()
        {
            var Input = "I";
            var Expected = 1;
            var Actual = RomanToInteger_13.RomanToInt(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
