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
    }
}
