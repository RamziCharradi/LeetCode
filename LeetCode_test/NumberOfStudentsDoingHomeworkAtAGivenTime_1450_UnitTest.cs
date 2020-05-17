using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;


namespace LeetCode_test
{
    [TestClass]
    public class NumberOfStudentsDoingHomeworkAtAGivenTime_1450_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_Start = new int[] { 1, 2, 3 };
            var Input_End = new int[] { 3, 2, 7 };
            var Input_Query = 4;
            var Expected = 1;
            var Actual = NumberOfStudentsDoingHomeworkAtAGivenTime_1450.BusyStudent(Input_Start, Input_End, Input_Query);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_Start = new int[] { 4 };
            var Input_End = new int[] { 4 };
            var Input_Query = 4;
            var Expected = 1;
            var Actual = NumberOfStudentsDoingHomeworkAtAGivenTime_1450.BusyStudent(Input_Start, Input_End, Input_Query);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_Start = new int[] { 4 };
            var Input_End = new int[] { 4 };
            var Input_Query = 5;
            var Expected = 0;
            var Actual = NumberOfStudentsDoingHomeworkAtAGivenTime_1450.BusyStudent(Input_Start, Input_End, Input_Query);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input_Start = new int[] { 1, 1, 1, 1 };
            var Input_End = new int[] { 1, 3, 2, 4 };
            var Input_Query = 7;
            var Expected = 0;
            var Actual = NumberOfStudentsDoingHomeworkAtAGivenTime_1450.BusyStudent(Input_Start, Input_End, Input_Query);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input_Start = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var Input_End = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            var Input_Query = 5;
            var Expected = 5;
            var Actual = NumberOfStudentsDoingHomeworkAtAGivenTime_1450.BusyStudent(Input_Start, Input_End, Input_Query);
            Assert.AreEqual(Expected, Actual);
        }

    }
}
