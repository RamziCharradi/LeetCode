using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MajorityElement_169_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMedthod1()
        {
            var Input = new int[] {3, 2, 3 };
            var Expected = 3;
            var Actual = MajorityElement_169.MajorityElement(Input);
            Assert.AreEqual(Expected, Actual);
        }
        
        [TestMethod, Timeout(20_000)]
        public void TestMedthod2()
        {
            var Input = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            var Expected = 2;
            var Actual = MajorityElement_169.MajorityElement(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
