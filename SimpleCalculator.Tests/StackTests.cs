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

        [TestMethod]
        public void CanCreateAnInstanceOfStack()
        {
            Assert.IsNotNull(TestStack);
        }

        [TestMethod]
        public void CanUseLastQ()
        {
            TestStack.LastQ("lastq");

            Assert.IsFalse(TestStack.DoThis);
        }

        [TestMethod]
        public void CanUseLastAnswer()
        {
            TestStack.LastAnswer("last", 5);

            Assert.IsFalse(TestStack.DoThis);
        }
    }
}
