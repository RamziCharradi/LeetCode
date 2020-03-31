using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class DistributeCandiesToPeople_1103_UnitTest
    {
        [TestMethod,Timeout(20_000)]
        public void TestMethod1()
        {
            var Input_Candies = 7;
            var Input_num_people = 4;
            var Expected = new int[]{ 1, 2, 3, 1 };
            var Actual = DistributeCandiesToPeople_1103.DistributeCandies(Input_Candies, Input_num_people);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var Input_Candies = 10;
            var Input_num_people = 3;
            var Expected = new int[] { 5, 2, 3 };
            var Actual = DistributeCandiesToPeople_1103.DistributeCandies(Input_Candies, Input_num_people);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
