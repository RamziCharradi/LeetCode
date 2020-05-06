using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.ComponentModel.DataAnnotations;

namespace LeetCode_test
{
    [TestClass]
    public class RemoveDuplicatesFromSortedList_83_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                }
            };
            var Expected = new ListNode(1)
            {
                next = new ListNode(2)
            };
            var Actual = RemoveDuplicatesFromSortedList_83.DeleteDuplicates(Input);
            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
        }
    }
}
