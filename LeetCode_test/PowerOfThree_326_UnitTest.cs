using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class PowerOfThree_326_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMthod1()
        {
            var Input = 27;
            var Expected = true;
            var Actual = PowerOfThree_326.IsPowerOfThree(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMthod2()
        {
            var Input = 0;
            var Expected = false;
            var Actual = PowerOfThree_326.IsPowerOfThree(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMthod3()
        {
            var Input = 9;
            var Expected = true;
            var Actual = PowerOfThree_326.IsPowerOfThree(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMthod4()
        {
            var Input = 45;
            var Expected = false;
            var Actual = PowerOfThree_326.IsPowerOfThree(Input);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
