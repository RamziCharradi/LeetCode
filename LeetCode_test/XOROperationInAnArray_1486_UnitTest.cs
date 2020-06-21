using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class XOROperationInAnArray_1486_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_n = 5;
            var Input_Start = 0;
            var Expected = 8;
            var Actual = XOROperationInAnArray_1486.XorOperation(Input_n, Input_Start);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_n = 4;
            var Input_Start = 3;
            var Expected = 8;
            var Actual = XOROperationInAnArray_1486.XorOperation(Input_n, Input_Start);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_n = 1;
            var Input_Start = 7;
            var Expected = 7;
            var Actual = XOROperationInAnArray_1486.XorOperation(Input_n, Input_Start);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_n = 10;
            var Input_Start = 5;
            var Expected = 2;
            var Actual = XOROperationInAnArray_1486.XorOperation(Input_n, Input_Start);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
