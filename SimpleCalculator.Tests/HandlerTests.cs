using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class HandlerTests
    {
        Handler TestHandler = new Handler();

        [TestMethod]
        public void CanInstantiateAnInstanceOfHandler()
        {
            Assert.IsNotNull(TestHandler);
        }

        [TestMethod]
        public void CanRunExitEffectively()
        {
            Assert.IsTrue(TestHandler.Exit("exit"));
            Assert.IsTrue(TestHandler.Exit("quit"));
            Assert.IsFalse(TestHandler.Exit("This should fail"));
        }
    }
}
