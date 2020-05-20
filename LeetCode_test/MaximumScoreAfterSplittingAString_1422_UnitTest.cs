using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MaximumScoreAfterSplittingAString_1422_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = "011101";
            var Expected = 5;
            var Actual = MaximumScoreAfterSplittingAString_1422.MaxScore(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = "00111";
            var Expected = 5;
            var Actual = MaximumScoreAfterSplittingAString_1422.MaxScore(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = "1111";
            var Expected = 3;
            var Actual = MaximumScoreAfterSplittingAString_1422.MaxScore(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
