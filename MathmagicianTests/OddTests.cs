﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void OddEnsureICanCreateClassInstance()
        {
            OddNumbers odd = new OddNumbers();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void OddShouldPrintFirstNumber()
        {
            OddNumbers odds = new OddNumbers();
            int expected = 1;
            int actual = odds.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers odds = new OddNumbers();
            int input = 1;
            int expected = 3;
            int actual = odds.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintAVariableSequenceOfNumbers()
        {
            OddNumbers odds = new OddNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] actual = odds.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddPrintSequenceOfNumbers()
        {
            OddNumbers odds = new OddNumbers();
            int length = 7;
            string expected = "1 3 5 7 9 11 13";
            string actual = odds.ToString(odds.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
