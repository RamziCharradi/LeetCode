using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class LongestWordInDictionary_720_UnitTest
    {
        [TestMethod, Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new string[] { "w", "wo", "wor", "worl", "world" };
            var Expected = "world";
            var Actual = LongestWordInDictionary_720.LongestWord(Input);
            Assert.AreEqual(Expected, Actual);
        
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new string[] { "a", "banana", "app", "appl", "ap", "apply", "apple" };
            var Expected = "apple";
            var Actual = LongestWordInDictionary_720.LongestWord(Input);
            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new string[] { "b", "br", "bre", "brea", "break", "breakf", "breakfa", "breakfas", "breakfast", "l", "lu", "lun", "lunc", "lunch", "d", "di", "din", "dinn", "dinne", "dinner" };
            var Expected = "breakfast";
            var Actual = LongestWordInDictionary_720.LongestWord(Input);
            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = new string[] { "rac", "rs", "ra", "on", "r", "otif", "o", "onpdu", "rsf", "rs", "ot", "oti", "racy", "onpd" };
            var Expected = "otif";
            var Actual = LongestWordInDictionary_720.LongestWord(Input);
            Assert.AreEqual(Expected, Actual);

        }

    }
}
