using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class MergeTwoSortedLists_21_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_l1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                }
            };

            var Input_l2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };

            var Expected =  new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(4)
                            }
                        }
                    }
                }
            };

            var Actual = MergeTwoSortedLists_21.MergeTwoLists(Input_l1, Input_l2);

            while (Expected != null && Actual != null)
            {
                Assert.AreEqual(Expected.val, Actual.val);
                Expected = Expected.next;
                Actual = Actual.next;
            }
        }
    }
}
