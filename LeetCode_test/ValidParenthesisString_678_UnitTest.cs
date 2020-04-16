using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ValidParenthesisString_678_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = "()";
            var Expected = true;
            var Actual = ValidParenthesisString_678.CheckValidString(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Input = "(*)";
            var Expected = true;
            var Actual = ValidParenthesisString_678.CheckValidString(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var Input = "(*))";
            var Expected = true;
            var Actual = ValidParenthesisString_678.CheckValidString(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var Input ="(((())))";
            var Expected = true;
            var Actual = ValidParenthesisString_678.CheckValidString(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
