using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MaximumNumberOfVowelsInASubstringOfGivenLength_1456_TestUnit
    {
        [TestMethod,Timeout(2_000)]
        public void testMethod1()
        {
            var Input_s = "abciiidef";
            var Input_k = 3;
            var Expected = 3;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethod2()
        {
            var Input_s = "aeiou";
            var Input_k = 2;
            var Expected = 2;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethod3()
        {
            var Input_s = "leetcode";
            var Input_k = 3;
            var Expected = 2;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethod4()
        {
            var Input_s = "rhythms";
            var Input_k = 4;
            var Expected = 0;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethod5()
        {
            var Input_s = "tryhard";
            var Input_k = 4;
            var Expected = 1;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void testMethod6()
        {
            var Input_s = "weallloveyou";
            var Input_k = 7;
            var Expected = 4;
            var Actual = MaximumNumberOfVowelsInASubstringOfGivenLength_1456.MaxVowels(Input_s, Input_k);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
