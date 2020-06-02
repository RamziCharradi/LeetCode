using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class QueensThatCanAttackTheKing_1222_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            //[[0,0],[1,1],[2,2],[3,4],[3,5],[4,4],[4,5]]
            var Input_Queens = new int[][]
            {
                new int[]{0,0},
                new int[]{1,1},
                new int[]{2,2},
                new int[]{3,4},
                new int[]{3,5},
                new int[]{4,4},
                new int[]{4,5}
            };
            var Input_king = new int[] { 3, 3 };
            //[[2,2],[3,4],[4,4]]
            var Expected = new int[][]
            {
                new int[]{2,2},
                new int[]{3,4},
                new int[]{4,4}
            };
            var Actual = QueensThatCanAttackTheKing_1222.QueensAttacktheKing(Input_Queens, Input_king);
            Assert.AreEqual(Expected.Length, Actual.Count);
            foreach (var q in Actual)
            {
                Assert.IsTrue(Expected.Any(x=>x.SequenceEqual(q)));
                
            }
        }
    }
}
