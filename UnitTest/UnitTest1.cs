using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DevideAndReturn;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DevideAndReturn.Program.ProcessNumber("3");
        }

        [TestMethod]
        public void TestMethod2()
        {
            DevideAndReturn.Program.ProcessNumber("5");
        }

        [TestMethod]
        public void TestMethod3()
        {
            DevideAndReturn.Program.ProcessNumber("15");
        }

        [TestMethod]
        public void TestMethod4()
        {
            DevideAndReturn.Program.ProcessNumber("A");
        }
    }
}
