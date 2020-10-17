using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Echo.Tests
{
    [TestClass()]
    public class EchoTests
    {
        [TestMethod()]
        public void GetMessageTest0Arg()
        {
            string actual = new Echo().GetMessage(new string[0]);
            Assert.AreEqual("", actual);
        }

        [TestMethod()]
        public void GetMessageTest1Arg()
        {
            string actual = new Echo().GetMessage(new string[] { "a" });
            Assert.AreEqual("a", actual);
        }

        [TestMethod()]
        public void GetMessageTest2Args()
        {
            string actual = new Echo().GetMessage(new string[] { "a", "b" });
            Assert.AreEqual("a b", actual);
        }

        [TestMethod()]
        public void GetMessageTest3Args()
        {
            string actual = new Echo().GetMessage(new string[] { "a", "b", "c" });
            Assert.AreEqual("a b c", actual);
        }

        [TestMethod()]
        public void GetMessageTestNullArg()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Echo().GetMessage(null));
        }


    }
}