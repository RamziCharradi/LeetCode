using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Linq;

namespace LeetCode_test
{
    [TestClass]
    public class GroupAnagrams_49_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> Expected = new List<IList<string>>()
            {
                new List<string>{"ate","eat","tea"},
                new List<string>{"nat","tan"},
                new List<string>{ "bat"}
            };
            var Actual = GroupAnagrams_49.GroupAnagrams(Input);
            Assert.AreEqual(Expected.Count, Actual.Count);
            for (int i = 0; i < Expected.Count; i++)
            {
                for (int j = 0; j < Expected[i].Count; j++)
                {
                    CollectionAssert.Contains(Expected[i].ToList(), Actual[i][j]);
                }
            }
        }
    }
}
