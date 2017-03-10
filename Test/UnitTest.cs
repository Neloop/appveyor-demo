using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appveyor_demo;

namespace Test {
    [TestClass]
    public class UnitTest {
        [TestMethod]
        public void ZeroFactorial_Test() {
            Factorial factorial = new Factorial();
            Assert.AreEqual(0, factorial.compute(0));
        }

        [TestMethod]
        public void OneFactorial_Test() {
            Factorial factorial = new Factorial();
            Assert.AreEqual(1, factorial.compute(1));
        }

        [TestMethod]
        public void TwoFactorial_Test() {
            Factorial factorial = new Factorial();
            Assert.AreEqual(2, factorial.compute(2));
        }
    }
}
