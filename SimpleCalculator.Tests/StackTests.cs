using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        Stack TestStack = new Stack();
        public bool DoThis = true;

        [TestMethod]
        public void CanCreateAnInstanceOfStack()
        {
            Assert.IsNotNull(TestStack);
        }

        [TestMethod]
        public void CanUseLastQ()
        {
            TestStack.LastQ("lastq");
            Assert.IsFalse(DoThis);

            TestStack.LastQ("DoThis should remain true");
            Assert.IsTrue(DoThis);
        }
    }
}
