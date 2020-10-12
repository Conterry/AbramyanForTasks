using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhileAbramyan.Tests
{
    [TestClass]
    public class WhileTasksTests
    {
        [TestMethod]
        public static void While9_8_2()
        {
            int n = 8;
            double expected = 2;

            int actual = WhileTasks.While9(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public static void While12_10_1()
        {
            int n = 10;
            double expected = 1;

            int actual = WhileTasks.While12(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
