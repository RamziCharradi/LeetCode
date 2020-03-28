using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_test
{
    [TestClass]
    public class FirstUniqueCharacterInAString_387_UnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "LeetCode";
            var expected = 0;
            var actual = FirstUniqueCharacterInAString_387.FirstUniqChar(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "loveleetcode";
            var expected = 2;
            var actual = FirstUniqueCharacterInAString_387.FirstUniqChar(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
