using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class IsomorphicStrings_205_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input_S = "egg";
            var Input_T = "add";
            var Expected = true;
            var Actual = IsomorphicStrings_205.IsIsomorphic(Input_S, Input_T);
            Assert.AreEqual(Expected,Actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var Input_S = "foo";
            var Input_T = "bar";
            var Expected = false;
            var Actual = IsomorphicStrings_205.IsIsomorphic(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var Input_S = "paper";
            var Input_T = "title";
            var Expected = true;
            var Actual = IsomorphicStrings_205.IsIsomorphic(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var Input_S = "ab";
            var Input_T = "aa";
            var Expected = false;
            var Actual = IsomorphicStrings_205.IsIsomorphic(Input_S, Input_T);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
