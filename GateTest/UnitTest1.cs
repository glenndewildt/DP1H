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
        public void OrTestAdd()
        {
            OR n = new OR();
            n.Add(new OR());            

            Assert.AreEqual(1, n.GetConnectedNodes().Count);

        }
        public void OrTestRemove()
        {
            OR n = new OR();
            OR a= new OR();
            n.Add(a);
            n.Remove(a);

            Assert.AreEqual(0, n.GetConnectedNodes().Count);
        }
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
        public void NotTestAdd()
        {
            NOT n = new NOT();
            n.Add(new NOT());

            Assert.AreEqual(1, n.GetConnectedNodes().Count);

        }
        public void NotTestRemove()
        {
            NOT n = new NOT();
            NOT a = new NOT();
            n.Add(a);
            n.Remove(a);

            Assert.AreEqual(0, n.GetConnectedNodes().Count);
        }

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
        public void AndTestAdd()
        {
            AND n = new AND();
            n.Add(new AND());

            Assert.AreEqual(1, n.GetConnectedNodes().Count);

        }
        public void AndTestRemove()
        {
            AND n = new AND();
            AND a = new AND();
            n.Add(a);
            n.Remove(a);

            Assert.AreEqual(0, n.GetConnectedNodes().Count);
        }

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
