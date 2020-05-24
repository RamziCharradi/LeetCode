using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class PrefixOfAnyWordInASentence_1455_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_Sentence = "i love eating burger";
            var Input_searchWord = "burg";
            var Expected = 4;
            var Actual = PrefixOfAnyWordInASentence_1455.IsPrefixOfWord(Input_Sentence, Input_searchWord);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_Sentence = "this problem is an easy problem";
            var Input_searchWord = "pro";
            var Expected = 2;
            var Actual = PrefixOfAnyWordInASentence_1455.IsPrefixOfWord(Input_Sentence, Input_searchWord);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_Sentence = "i am tired";
            var Input_searchWord = "you";
            var Expected = -1;
            var Actual = PrefixOfAnyWordInASentence_1455.IsPrefixOfWord(Input_Sentence, Input_searchWord);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_Sentence = "i use triple pillow";
            var Input_searchWord = "pill";
            var Expected = 4;
            var Actual = PrefixOfAnyWordInASentence_1455.IsPrefixOfWord(Input_Sentence, Input_searchWord);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input_Sentence = "hello from the other side";
            var Input_searchWord = "they";
            var Expected = -1;
            var Actual = PrefixOfAnyWordInASentence_1455.IsPrefixOfWord(Input_Sentence, Input_searchWord);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
