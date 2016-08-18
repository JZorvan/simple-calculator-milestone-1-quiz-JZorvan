using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        Expression TestExpression = new Expression();
        static string pattern = @"^(?<Num1>-?\d+)\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>-?\d+)";
        Regex Regex = new Regex(pattern);

        [TestMethod]
        public void CanCreateAnInstanceOfExpression()
        {
            Assert.IsNotNull(TestExpression);
        }

        [TestMethod]
        public void CanCheckInputAgainstRegex()
        {
            string test1 = "1+2";
            string test2 = "-58877 - -980009";
            string test3 = "3*8";
            string test4 = "9/3";
            string test5 = "9 % 3";
            string test6 = "balls";

            Assert.IsTrue(Regex.IsMatch(test1));
            Assert.IsTrue(Regex.IsMatch(test2));
            Assert.IsTrue(Regex.IsMatch(test3));
            Assert.IsTrue(Regex.IsMatch(test4));
            Assert.IsTrue(Regex.IsMatch(test5));
            Assert.IsFalse(Regex.IsMatch(test6));
        }
    }
}
