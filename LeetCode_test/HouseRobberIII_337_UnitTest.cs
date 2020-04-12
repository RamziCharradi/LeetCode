using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class HouseRobberIII_337_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new TreeNode(3)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(3)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(1)
                }
            };
            var Expected = 7;
            var Actual = HouseRobberIII_337.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            //[4,1,null,2,null,3]
            var Input = new TreeNode(4)
            {
              left = new TreeNode(1)
              {
                  left = new TreeNode(2)
                  {
                      left = new TreeNode(3)
                  }
              }
            };
            var Expected = 7;
            var Actual = HouseRobberIII_337.Rob(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
