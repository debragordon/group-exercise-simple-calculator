using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ParserTests
    {
        Parser parser = new Parser();

        [TestMethod]
        public void AccessFirstTerm()
        {
            parser.ParseInput("2 + 1");
            Assert.AreEqual(parser.FirstTerm, 2);
        }

        [TestMethod]
        public void AccessSecondTerm()
        {
            parser.ParseInput("5 + 10");
            Assert.AreEqual(parser.SecondTerm, 10);
        }

        [TestMethod]
        public void AccessOperator()
        {
            parser.ParseInput("5 % 3");
            Assert.AreEqual(parser.Operator, '%');
        }
    }
}
