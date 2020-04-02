using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class FindLuckyIntegerInAnArray_1394_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMedthod1()
        {
            var Input = new int[] { 2, 2, 3, 4 };
            var Expected = 2;
            var Actual = FindLuckyIntegerInAnArray_1394.FindLucky(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMedthod2()
        {
            var Input = new int[] { 1, 2, 2, 3, 3, 3 };
            var Expected = 3;
            var Actual = FindLuckyIntegerInAnArray_1394.FindLucky(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMedthod3()
        {
            var Input = new int[] { 2, 2, 2, 3, 3 };
            var Expected = -1;
            var Actual = FindLuckyIntegerInAnArray_1394.FindLucky(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMedthod4()
        {
            var Input = new int[] { 5 };
            var Expected = -1;
            var Actual = FindLuckyIntegerInAnArray_1394.FindLucky(Input);
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMedthod5()
        {
            var Input = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            var Expected = 7;
            var Actual = FindLuckyIntegerInAnArray_1394.FindLucky(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
