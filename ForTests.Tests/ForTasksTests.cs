using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ForAbramyan.Tests
{

    
    [TestClass]
    public class ForTasksTests
    {
        [TestMethod]
        public void For9_1and3_14()
        {
            int a = 1;
            int b = 3;
            int expected = 14;

            int actual = ForTasks.For9(a, b);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void For13_2_01()
        {
            int n = 2;
            double expected = -0.1;

            double actual = ForTasks.For13(n);

            Assert.AreEqual(expected, actual, 0.01);
        }

        
    }
}
