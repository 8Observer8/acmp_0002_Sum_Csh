using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acmp_0002_Sum;

namespace UnitTestOfSum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum_from_1_to_5()
        {
            Sum s = new Sum();
            int n = 5;
            int actual = s.sum(n);
            int expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_2()
        {
            Sum s = new Sum();
            int n = 2;
            int actual = s.sum(n);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_zero()
        {
            Sum s = new Sum();
            int n = 0;
            int actual = s.sum(n);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_minus_1()
        {
            Sum s = new Sum();
            int n = -1;
            int actual = s.sum(n);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_minus_2()
        {
            Sum s = new Sum();
            int n = -2;
            int actual = s.sum(n);
            int expected = -2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_minus_3()
        {
            Sum s = new Sum();
            int n = -3;
            int actual = s.sum(n);
            int expected = -5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSum_from_1_to_minus_4()
        {
            Sum s = new Sum();
            int n = -4;
            int actual = s.sum(n);
            int expected = -9;
            Assert.AreEqual(expected, actual);
        }
    }
}
