using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RearrangeWordsInASentence_1451_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "Leetcode is cool";
            var Expected = "Is cool leetcode";
            var Actual = RearrangeWordsInASentence_1451.ArrangeWords(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = "Keep calm and code on";
            var Expected = "On and keep calm code";
            var Actual = RearrangeWordsInASentence_1451.ArrangeWords(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = "To be or not to be";
            var Expected = "To be or to be not";
            var Actual = RearrangeWordsInASentence_1451.ArrangeWords(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
