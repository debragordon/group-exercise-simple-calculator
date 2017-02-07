﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanIMakeStack()
        {
            Stack myStack = new Stack;
            Assert.IsNotNull(myStack);
        }
        [TestMethod]
        public void CanISetLastQuery()
        {
            //Assert
            Stack myStack = new Stack;
            string lastq = ("2 + 2");
            Assert.AreEqual(myStack.lastq, ("2 + 2"));
        }
        [TestMethod]
        public void CanISetLastAnswer()
        {
            Stack myStack = new Stack;
            string lastanswer = "4";
            Assert.AreEqual(myStack.lastq, "4");
        }
    }
}