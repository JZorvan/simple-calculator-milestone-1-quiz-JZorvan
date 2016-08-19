using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator TestCalculator = new Calculator();

        [TestMethod]
        public void CanInstantiateAnInstanceOfCalculator()
        {
            Assert.IsNotNull(TestCalculator);
        }

        [TestMethod]
        public void CanAdd()
        {
            int First = 2, Second = 2;

            Assert.AreEqual(TestCalculator.Addition(First, Second), 4);
        }

        [TestMethod]
        public void CanSubtract()
        {
            int First = 3, Second = 2;

            Assert.AreEqual(TestCalculator.Subtraction(First, Second), 1);

        }

        [TestMethod]
        public void CanMultiply()
        {
            int First = 2, Second = 5;

            Assert.AreEqual(TestCalculator.Multiplication(First, Second), 10);
        }

        [TestMethod]
        public void CanDivide()
        {
            int First = 6, Second = 3;
            int FirstFail = 3, SecondFail = 0;

            Assert.AreEqual(TestCalculator.Division(First, Second), 2);
            Assert.AreEqual(TestCalculator.Division(FirstFail, SecondFail), 0);
        }

        [TestMethod]
        public void CanUseModulus()
        {
            int First = 6, Second = 4;

            Assert.AreEqual(TestCalculator.Modulus(First, Second), 2);
        }
    }
}
