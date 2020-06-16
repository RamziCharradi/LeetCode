using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class PascalTriangle_118_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = 5;
            IList<IList<int>> Expected = new List<IList<int>>()
            {
                new List<int>{1},
                new List<int>{1,1},
                new List<int>{1,2,1},
                new List<int>{1,3,3,1},
                new List<int>{1,4,6,4,1},
            };
            var Actual = PascalTriangle_118.Generate(Input);
            Assert.AreEqual(Expected.Count, Actual.Count);
            for (int i = 0; i < Expected.Count; i++)
            {
                CollectionAssert.AreEqual(Expected[i].ToArray(), Actual[i].ToArray());
            }
        }


    }
}
