using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class FirstBadVersion_278_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 5;
            var Expected = 4;
            var Actual = FirstBadVersion_278.FirstBadVersion(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
