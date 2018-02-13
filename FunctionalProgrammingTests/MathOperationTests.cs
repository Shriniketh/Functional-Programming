using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalProgramming;

namespace FunctionalProgrammingTests
{
    [TestClass]
    public class MathOperationTests
    {
        [TestMethod]
        public void GetRandomNumbers_Returns_Random_Numbers_Successfully()
        {
            var randomNumber = MathOperation.GetRandomNumbers();

            Assert.IsNotNull(randomNumber);

        }

        [TestMethod]
        public void IsPrime_Returns_True()
        {
            var isPrimeNumber = MathOperation.IsPrime(3);

            Assert.IsTrue(isPrimeNumber);
        }

        [TestMethod]
        public void IsPrime_Returns_False()
        {
            var isPrimeNumber = MathOperation.IsPrime(2);

            Assert.IsTrue(isPrimeNumber);
        }

        [TestMethod]
        public void MathOperation_Returns_Two_Prime_Numbers()
        {
            var numbers = MathOperation.DoMathOperation();

            Assert.IsTrue(numbers.Count == 2);
        }
    }
}
