using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class DistanceBetweenBusStops_1184_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input_distance = new int[] { 1, 2, 3, 4 };
            var Input_start = 0;
            var Input_destination = 1;
            var Expected = 1;
            var Actual = DistanceBetweenBusStops_1184.DistanceBetweenBusStops(Input_distance, Input_start, Input_destination);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input_distance = new int[] { 1, 2, 3, 4 };
            var Input_start = 0;
            var Input_destination = 2;
            var Expected = 3;
            var Actual = DistanceBetweenBusStops_1184.DistanceBetweenBusStops(Input_distance, Input_start, Input_destination);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input_distance = new int[] { 1, 2, 3, 4 };
            var Input_start = 0;
            var Input_destination = 3;
            var Expected = 4;
            var Actual = DistanceBetweenBusStops_1184.DistanceBetweenBusStops(Input_distance, Input_start, Input_destination);
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            /*
            [7,10,1,12,11,14,5,0]
                7
                2 
            
             */
            var Input_distance = new int[] { 7, 10, 1, 12, 11, 14, 5, 0 };
            var Input_start = 7;
            var Input_destination = 2;
            var Expected = 17;
            var Actual = DistanceBetweenBusStops_1184.DistanceBetweenBusStops(Input_distance, Input_start, Input_destination);
            Assert.AreEqual(Expected, Actual);
        }
    }
}
