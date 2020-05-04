using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class IsSubsequence_392_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_s = "abc";
            var Input_t = "ahbgdc";
            var Expected = true;
            var Actual = IsSubsequence_392.IsSubsequence(Input_s, Input_t);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_s = "axc";
            var Input_t = "ahbgdc";
            var Expected = false;
            var Actual = IsSubsequence_392.IsSubsequence(Input_s, Input_t);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_s = "";
            var Input_t = "ahbgdc";
            var Expected = true;
            var Actual = IsSubsequence_392.IsSubsequence(Input_s, Input_t);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
