using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MinimumAddToMakeParenthesesValid_921_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void Testmethod1()
        {
            var Input = "())";
            var Expected = 1;
            var Actual = MinimumAddToMakeParenthesesValid_921.MinAddToMakeValid(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Testmethod2()
        {
            var Input = "(((";
            var Expected = 3;
            var Actual = MinimumAddToMakeParenthesesValid_921.MinAddToMakeValid(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Testmethod3()
        {
            var Input = "()";
            var Expected = 0;
            var Actual = MinimumAddToMakeParenthesesValid_921.MinAddToMakeValid(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Testmethod4()
        {
            var Input = "()))((";
            var Expected = 4;
            var Actual = MinimumAddToMakeParenthesesValid_921.MinAddToMakeValid(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
