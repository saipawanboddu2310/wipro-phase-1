using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Passwordstrengthmeter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string password = "Rajesh#123";
            int expected = 5;

            //act

            int actual = PassWordStrength.GetPasswordStrength(password);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
