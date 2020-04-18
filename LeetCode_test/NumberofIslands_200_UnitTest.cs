using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class NumberofIslands_200_UnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var Input = new char[][]
            {
                new char[]{ '1','1','1','1','0' },
                new char[]{ '1','1','0','1','0' },
                new char[]{ '1','1','0','0','0' },
                new char[]{ '0','0','0','0','0' }
            };
            var Expected = 1;
            var Actual = NumberofIslands_200.NumIslands(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input = new char[][]
            {
                new char[]{ '1','1','0','0','0' },
                new char[]{ '1','1','0','0','0' },
                new char[]{ '0','0','1','0','0' },
                new char[]{ '0', '0', '0', '1', '1' }
            };
            var Expected = 3;
            var Actual = NumberofIslands_200.NumIslands(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var Input = new char[][]
            {
                new char[]{ '1','1','1' },
                new char[]{ '0','1','0' },
                new char[]{ '1','1','1' },
            };
            var Expected = 1;
            var Actual = NumberofIslands_200.NumIslands(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
