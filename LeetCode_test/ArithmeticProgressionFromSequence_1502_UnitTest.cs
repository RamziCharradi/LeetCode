using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ArithmeticProgressionFromSequence_1502_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void testMethode1()
        {
            var Input = new int[] { 3, 5, 1 };
            var Expected = true;
            var Actual = ArithmeticProgressionFromSequence_1502.CanMakeArithmeticProgression(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethode2()
        {
            var Input = new int[] { 1, 2, 4 };
            var Expected = false;
            var Actual = ArithmeticProgressionFromSequence_1502.CanMakeArithmeticProgression(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
