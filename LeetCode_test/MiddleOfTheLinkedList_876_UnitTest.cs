using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MiddleOfTheLinkedList_876_UnitTest
    {
        [TestMethod, Timeout(20_000)]
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
            var Expected = new ListNode(3)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };
            var Actual = MiddleOfTheLinkedList_876.MiddleNode(Input);

            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
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
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
            var Expected = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(6)
                }
            };
            var Actual = MiddleOfTheLinkedList_876.MiddleNode(Input);

            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
        }

    }
}
