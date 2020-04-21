using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ReverseWordsInAStringIII_557_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = "Let's take LeetCode contest";
            var Expected = "s'teL ekat edoCteeL tsetnoc";
            var Actual = ReverseWordsInAStringIII_557.ReverseWords(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
