using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RearrangeSpacesBetweenWords_1592_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "  this   is  a sentence ";
            var Expected = "this   is   a   sentence";
            var Actual = RearrangeSpacesBetweenWords_1592.ReorderSpaces(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
