using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MostCommonWord_819_UNitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var Input_Banned = new string[] { "hit" };
            var Expected = "ball";
            var Actual = MostCommonWord_819.MostCommonWord(Input_paragraph, Input_Banned);
            Assert.AreEqual(Expected, Actual);
        }

       
    }
}
