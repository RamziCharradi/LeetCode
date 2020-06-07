using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class GroupsOfSpecialEquivalentStrings_893_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new string[] { "abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx" };
            var Expected = 3;
            var Actual = GroupsOfSpecialEquivalentStrings_893.NumSpecialEquivGroups(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
