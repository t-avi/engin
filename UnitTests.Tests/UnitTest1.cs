using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var quad = new QuadEq();

            var list = quad.ResultPlease(1, 3, -4);

            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var quad = new QuadEq();

            var list = quad.ResultPlease(1, 3, -4);

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(-4, list[1]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var quad = new QuadEq();

            var list = quad.ResultPlease(3, -18, 27);

            Assert.AreEqual(1, list.Count);
        }
    }
}
