using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode_test
{
    [TestClass]
    public class Non_decreasing_Array_655_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new int[] { 4, 2, 3 };
            var Expected = true;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new int[] { 4, 2, 1 };
            var Expected = false;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new int[] {-1, 4, 2, 3 };
            var Expected = true;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = new int[] { -1, 4, 2, 3 ,1};
            var Expected = false;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input = new int[] { -1, 4, 2, 3, 1,  7 };
            var Expected = false;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }


        [TestMethod, Timeout(2_000)]
        public void TestMethod6()
        {
            var Input = new int[] { 3, 4, 2, 3 };
            var Expected = false;
            var Actual = Non_decreasing_Array_655.CheckPossibility(Input);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
