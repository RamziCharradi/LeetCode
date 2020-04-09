using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class RemoveLinkedListElements_203_UnitTest
    {
       [TestMethod]
       public void TestMethod1()
       {
            var Input_head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(6)
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
                }
            };
            var Input_val = 6;

            var Expected = new ListNode(1)
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

            var Actual = RemoveLinkedListElements_203.RemoveElements(Input_head, Input_val);

            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
        }
    }
}
