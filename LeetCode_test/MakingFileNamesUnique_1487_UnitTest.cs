using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_test
{
    [TestClass]
    public class MakingFileNamesUnique_1487_UnitTest
    {
        [TestMethod,Timeout(2_000)]
        public void TestMethod1()
        {
            var Input = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            var Expected = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var Input = new string[] { "gta", "gta(1)", "gta", "avalon" };
            var Expected = new string[] { "gta","gta(1)","gta(2)","avalon" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var Input = new string[] { "onepiece", "onepiece(1)", "onepiece(2)", "onepiece(3)", "onepiece" };
            var Expected = new string[] { "onepiece", "onepiece(1)", "onepiece(2)", "onepiece(3)", "onepiece(4)" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var Input = new string[] { "wano", "wano", "wano", "wano" };
            var Expected = new string[] { "wano", "wano(1)", "wano(2)", "wano(3)" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod5()
        {
            var Input = new string[] { "kaido", "kaido(1)", "kaido", "kaido(1)" };
            var Expected = new string[] { "kaido", "kaido(1)", "kaido(2)", "kaido(1)(1)" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod6()
        {
            //["kaido","kaido(1)","kaido(2)","kaido(1)(1)","kaido(2)(1)"]

            var Input = new string[] { "kaido", "kaido(1)", "kaido", "kaido(1)", "kaido(2)" };
            var Expected = new string[] { "kaido", "kaido(1)", "kaido(2)", "kaido(1)(1)", "kaido(2)(1)" };
            var Actual = MakingFileNamesUnique_1487.GetFolderNames(Input);
            CollectionAssert.AreEqual(Expected, Actual);
        }
    }
}
