using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        Expression TestExpression = new Expression();
        string TestInput = "-23";

        [TestMethod]
        public void CanCreateAnInstanceOfExpression()
        {
            Assert.IsNotNull(TestExpression);
        }

        [TestMethod]
        public void CanCheckIfFirstCharIsNeg()
        {
            Assert.IsTrue(TestInput.StartsWith("-"));
        }

        [TestMethod]
        public void CanAddHyphenIfAtStartOfString()
        {
            TestExpression.Slicer(TestInput);
            Assert.AreEqual(TestExpression.First, "-");
        }

        [TestMethod]
        public void CanRemoveLeadingHyphenFromOriginalString()
        {
            TestExpression.Slicer(TestInput);
            Assert.AreEqual(TestInput, "23");
            // Why the hell isn't this working??
        }
    }
}
