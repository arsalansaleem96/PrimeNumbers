using NUnit.Framework;
using PrimeNumbers;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        #region Test cases for Prime Generator from 1 to 11
        [Test]
        public void TestPrime1()
        {
            HashSet<int> primes = PrimeGenerator.Generate(1);
            HashSet<int> test = new HashSet<int>() { 2 };
            Assert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime3()
        {
            HashSet<int> primes = PrimeGenerator.Generate(3);
            HashSet<int> test = new HashSet<int>() { 2, 3, 5 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime5()
        {
            HashSet<int> primes = PrimeGenerator.Generate(5);
            HashSet<int> test = new HashSet<int>() { 2, 3, 5, 7, 11 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime7()
        {
            HashSet<int> primes = PrimeGenerator.Generate(7);
            HashSet<int> test = new HashSet<int>() { 2, 3, 5, 7, 11, 13, 17 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime11()
        {
            HashSet<int> primes = PrimeGenerator.Generate(11);
            HashSet<int> test = new HashSet<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
            CollectionAssert.AreEqual(test, primes);
        }
        #endregion
        #region Test cases for Prime Multiplication Table 2,3 and 5
        [Test]
        public void TestPrimeMul2()
        {
            HashSet<int> input = new HashSet<int>() { 2, 3 };
            List<List<int>> output = HelperFunctions.MultiplyPrimes(input);
            List<List<int>> test = new List<List<int>>();
            test.Add(new List<int> { 4, 6 });
            test.Add(new List<int> { 6, 9});
            CollectionAssert.AreEqual(test[0], output[0]);
            CollectionAssert.AreEqual(test[1], output[1]);
        }
        [Test]
        public void TestPrimeMul3()
        {
            HashSet<int> input = new HashSet<int>() { 2, 3, 5 };
            List<List<int>> output = HelperFunctions.MultiplyPrimes(input);
            List<List<int>> test = new List<List<int>>();
            test.Add(new List<int> { 4, 6, 10 });
            test.Add(new List<int> { 6, 9, 15 });
            test.Add(new List<int> { 10, 15, 25 });
            CollectionAssert.AreEqual(test[0], output[0]);
            CollectionAssert.AreEqual(test[1], output[1]);
            CollectionAssert.AreEqual(test[2], output[2]);
        }
        [Test]
        public void TestPrimeMul5()
        {
            HashSet<int> input = new HashSet<int>() { 2, 3, 5, 7, 11 };
            List<List<int>> output = HelperFunctions.MultiplyPrimes(input);
            List<List<int>> test = new List<List<int>>();
            test.Add(new List<int> { 4, 6, 10, 14, 22 });
            test.Add(new List<int> { 6, 9, 15, 21, 33 });
            test.Add(new List<int> { 10, 15, 25, 35, 55 });
            test.Add(new List<int> { 14, 21, 35, 49, 77 });
            test.Add(new List<int> { 22, 33, 55, 77, 121 });
            CollectionAssert.AreEqual(test[0], output[0]);
            CollectionAssert.AreEqual(test[1], output[1]);
            CollectionAssert.AreEqual(test[2], output[2]);
        }
        #endregion
    }
}