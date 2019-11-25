using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Start test");
            int i = 0;
            i = 1 / i;
            Console.WriteLine("Test done");
        }
    }
}
