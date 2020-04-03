using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class PalindromeLinkedList_234_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new ListNode(1) { next = new ListNode(2) };
            var Expected = false;
            var Actual = PalindromeLinkedList_234.IsPalindrome(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new ListNode(1) { next = new ListNode(2) {next = new ListNode(2) {next = new ListNode(1) } } };
            var Expected = true;
            var Actual = PalindromeLinkedList_234.IsPalindrome(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new ListNode(-121) { next = new ListNode(-121) };
            var Expected = true;
            var Actual = PalindromeLinkedList_234.IsPalindrome(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
