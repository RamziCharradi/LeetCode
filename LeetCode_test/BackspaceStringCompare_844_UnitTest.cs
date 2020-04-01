using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class BackspaceStringCompare_844_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_S = "ab#c";
            var Input_T = "ad#c";
            var Expected = true;
            var Actual = BackspaceStringCompare_844.BackspaceCompare(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_S = "ab##";
            var Input_T = "c#d#";
            var Expected = true;
            var Actual = BackspaceStringCompare_844.BackspaceCompare(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input_S = "a##c";
            var Input_T = "#a#c";
            var Expected = true;
            var Actual = BackspaceStringCompare_844.BackspaceCompare(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input_S = "a#c";
            var Input_T = "b";
            var Expected = false;
            var Actual = BackspaceStringCompare_844.BackspaceCompare(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var Input_S = "xywrrmp";
            var Input_T = "xywrrmu#p";
            var Expected = true;
            var Actual = BackspaceStringCompare_844.BackspaceCompare(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
