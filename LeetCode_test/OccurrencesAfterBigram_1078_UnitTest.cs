using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class OccurrencesAfterBigram_1078_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMthod1()
        {
            var Input_text = "alice is a good girl she is a good student";
            var Input_first = "a";
            var Input_Second = "good";
            var Expected = new string[]{ "girl", "student" };
            var Actual = OccurrencesAfterBigram_1078.FindOcurrences(Input_text, Input_first, Input_Second);
            CollectionAssert.AreEqual(Expected, Actual);

        }

        [TestMethod, Timeout(2_000)]
        public void TestMthod2()
        {
            var Input_text = "we will we will rock you";
            var Input_first = "we";
            var Input_Second = "will";
            var Expected = new string[] { "we", "rock" };
            var Actual = OccurrencesAfterBigram_1078.FindOcurrences(Input_text, Input_first, Input_Second);
            CollectionAssert.AreEqual(Expected, Actual);

        }
    }
}
