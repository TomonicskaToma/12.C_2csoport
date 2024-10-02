using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartErdem = "Hello world";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                test.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                Assert.AreEqual(vartErdem, kapottEredm);
                
            }

        }
    }
}
