using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class UniqueEmailAddresses_929_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new string[] { @"test.email+alex@leetcode.com", @"test.e.mail+bob.cathy@leetcode.com", @"testemail+david@lee.tcode.com" };
            var Expected = 2;
            var Actual = UniqueEmailAddresses_929.NumUniqueEmails(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
