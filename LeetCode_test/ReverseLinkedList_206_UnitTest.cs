using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class ReverseLinkedList_206_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            var Expected = new ListNode(5)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                    }
                }
            };

            var Actual = ReverseLinkedList_206.ReverseList(Input);
            
            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
            
            
        }

    }
}
