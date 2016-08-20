using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        Constants TestConstants = new Constants();

        [TestMethod]
        public void CanInstantiateAnInstanceOfConstants()
        {
            Assert.IsNotNull(TestConstants);
        }

        [TestMethod]
        public void CanSetAConstant()
        {
            TestConstants.SliceConstant("x=3");

            Assert.AreEqual(TestConstants.Variable, "x");
            Assert.AreEqual(TestConstants.ConstantValue, 3);
        }
    }
}
