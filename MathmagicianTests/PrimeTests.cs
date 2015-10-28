using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        {
            PrimeNumbers prime = new PrimeNumbers();
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int expected = 2;
            int actual = primes.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimesShouldPrintNextNumber()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int input = 2;
            int expected = 3;
            int actual = primes.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimesShouldPrintAVariableSequenceOfNumbers()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19};
            int[] actual = primes.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimesPrintSequenceOfNumbers()
        {
            PrimeNumbers primes = new PrimeNumbers();
            int length = 7;
            string expected = "2 3 5 7 11 13 17";
            string actual = primes.ToString(primes.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeFindIndexOfElement()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            int expected = 20;
            int actual = prime.FindIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeGetNextNonPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 105;
            prime.GetNext(input);
        }

        [TestMethod]
        public void PrimeIsPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            bool expected = true;
            bool actual = prime.isPrime(input);
            Assert.AreEqual(expected, actual);
        }
    }
}