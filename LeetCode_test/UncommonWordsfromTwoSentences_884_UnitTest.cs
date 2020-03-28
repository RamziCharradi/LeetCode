using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class UncommonWordsfromTwoSentences_884_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void Medthod1()
        {
            var Input_A = "this apple is sweet";
            var Input_B = "this apple is sour";
            var expected = new string[] { "sweet", "sour" };
            var actual = UncommonWordsfromTwoSentences_884.UncommonFromSentences(Input_A, Input_B);
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var str in actual)
            {
                Assert.IsTrue(expected.ToList().Contains(str));
            }
        }

        [TestMethod, Timeout(20_000)]
        public void Medthod2()
        {
            var Input_A = "apple apple";
            var Input_B = "banana";
            var expected = new string[] { "banana" };
            var actual = UncommonWordsfromTwoSentences_884.UncommonFromSentences(Input_A, Input_B);
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var str in actual)
            {
                Assert.IsTrue(expected.ToList().Contains(str));
            }
        }

        [TestMethod, Timeout(20_000)]
        public void Medthod3()
        {
            var Input_A = "s z z z s";
            var Input_B = "s z ejt";
            var expected = new string[] { "ejt" };
            var actual = UncommonWordsfromTwoSentences_884.UncommonFromSentences(Input_A, Input_B);
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var str in actual)
            {
                Assert.IsTrue(expected.ToList().Contains(str));
            }
        }

    }
}
