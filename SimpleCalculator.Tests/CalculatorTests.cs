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

    }
}
