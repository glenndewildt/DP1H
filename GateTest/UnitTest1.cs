using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP1H.Model;

namespace GateTest
{
    [TestClass]
    public class Gate
    {
        //OR logic tests
        [TestMethod]
        public void OrTestPositive()
        {
            OR n = new OR();
            n.input2 = 0;
            n.input1 = 0;
            n.Calculate();

            Assert.AreEqual(0, n.Calculate());

        }
        [TestMethod]
        public void OrTestNagative1()
        {
            OR n = new OR();
            n.input2 = 1;
            n.input1 = 0;
            n.Calculate();

            Assert.AreEqual(1, n.Calculate());

        }
        [TestMethod]
        public void OrTestNagative2()
        {
            OR n = new OR();
            n.input2 = 0;
            n.input1 = 1;
            n.Calculate();

            Assert.AreEqual(1, n.Calculate());

        }
        [TestMethod]
        public void OrTestNagative3()
        {
            OR n = new OR();
            n.input2 = 1;
            n.input1 = 1;
            n.Calculate();

            Assert.AreEqual(1, n.Calculate());

        }
        //NOT logic tests
        [TestMethod]
        public void NotTestPositive()
        {
            NOT n = new NOT();
            n.input1 = 1;
            n.Calculate();

            Assert.AreEqual(0, n.Calculate());

        }
        [TestMethod]
        public void NotTestNagative()
        {
            NOT n = new NOT();
            n.input1 = 0;
            n.Calculate();

            Assert.AreEqual(1, n.Calculate());

        }

        //AND logic tests

        [TestMethod]
        public void AndTestPositive()
        {
            AND n = new AND();
            n.input2 = 1;
            n.input1 = 1;
            n.Calculate();

            Assert.AreEqual(1, n.Calculate());

        }
        [TestMethod]
        public void AndTestNagative1()
        {
            AND n = new AND();
            n.input2 = 0;
            n.input1 = 0;
            n.Calculate();

            Assert.AreEqual(0, n.Calculate());

        }
        [TestMethod]
        public void AndTestNagative2()
        {
            AND n = new AND();
            n.input2 = 0;
            n.input1 = 1;
            n.Calculate();

            Assert.AreEqual(0, n.Calculate());

        }
        [TestMethod]
        public void AndTestNagative3()
        {
            AND n = new AND();
            n.input2 = 1;
            n.input1 = 0;
            n.Calculate();

            Assert.AreEqual(0, n.Calculate());

        }
    }
}
