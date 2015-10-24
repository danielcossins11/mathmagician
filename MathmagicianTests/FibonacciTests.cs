﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibShouldPrintFirstNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int expected = 1;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintNextNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 1;
            int expected = 1;
            int actual = fib.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21 };
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibPrintSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
