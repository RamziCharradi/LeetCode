using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class LemonadeChange_860_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 5, 5, 5, 10, 20 };
            var Expected = true;
            var Actual = LemonadeChange_860.LemonadeChange(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 5, 5, 10 };
            var Expected = true;
            var Actual = LemonadeChange_860.LemonadeChange(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new int[] { 10 , 10 };
            var Expected = false;
            var Actual = LemonadeChange_860.LemonadeChange(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var Input = new int[] { 5, 5, 10, 10, 20 };
            var Expected = false;
            var Actual = LemonadeChange_860.LemonadeChange(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
