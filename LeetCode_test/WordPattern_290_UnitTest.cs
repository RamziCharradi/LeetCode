using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class WordPattern_290_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_Pattern = "abba";
            var Input_Str = "dog cat cat dog";
            var Expected = true;
            var Actual = WordPattern_290.WordPattern(Input_Pattern, Input_Str);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_Pattern = "abba";
            var Input_Str = "dog cat cat fish";
            var Expected = false;
            var Actual = WordPattern_290.WordPattern(Input_Pattern, Input_Str);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input_Pattern = "aaaa";
            var Input_Str = "dog cat cat dog";
            var Expected = false;
            var Actual = WordPattern_290.WordPattern(Input_Pattern, Input_Str);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input_Pattern = "abba";
            var Input_Str = "dog dog dog dog";
            var Expected = false;
            var Actual = WordPattern_290.WordPattern(Input_Pattern, Input_Str);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var Input_Pattern = "e";
            var Input_Str = "eukera";
            var Expected = true;
            var Actual = WordPattern_290.WordPattern(Input_Pattern, Input_Str);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
