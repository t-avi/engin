using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountTest()
        {
            var quad = new QuadEq(); //объявляем

            var list = quad.ResultPlease(1, 3, -4); //делаем

            Assert.AreEqual(2, list.Count); //проверям
        }

        [TestMethod]
        public void ResultTest()
        {
            var quad = new QuadEq();

            var list = quad.ResultPlease(1, 3, -4);

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(-4, list[1]);
        }

        [TestMethod]
        public void EqualCountTest()
        {
            var quad = new QuadEq();

            var list = quad.ResultPlease(3, -18, 27); //одинаковые корни

            Assert.AreEqual(1, list.Count);
        }
    }
}
