using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class ReformatTheString_1417_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = "a0b1c2";
            var Expected = "0a1b2c";
            var Actual = ReformatTheString_1417.Reformat(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = "leetcode";
            var Expected = "";
            var Actual = ReformatTheString_1417.Reformat(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = "1229857369";
            var Expected = "";
            var Actual = ReformatTheString_1417.Reformat(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input = "covid2019";
            var Expected = "c2o0v1i9d";
            var Actual = ReformatTheString_1417.Reformat(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var Input = "ab123";
            var Expected = "1a2b3";
            var Actual = ReformatTheString_1417.Reformat(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
