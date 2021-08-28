using NUnit.Framework;
using PrimeNumbers;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestPrime1()
        {
            List<int> primes = PrimeGenerator.Generate(1);
            Assert.AreEqual(2, primes[0]);
        }
        [Test]
        public void TestPrime3()
        {
            List<int> primes = PrimeGenerator.Generate(3);
            List<int> test = new List<int>() { 2, 3, 5 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime5()
        {
            List<int> primes = PrimeGenerator.Generate(5);
            List<int> test = new List<int>() { 2, 3, 5, 7, 11 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime7()
        {
            List<int> primes = PrimeGenerator.Generate(7);
            List<int> test = new List<int>() { 2, 3, 5, 7, 11, 13, 17 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrime11()
        {
            List<int> primes = PrimeGenerator.Generate(11);
            List<int> test = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
            CollectionAssert.AreEqual(test, primes);
        }
        [Test]
        public void TestPrimeMul2()
        {
            List<int> input = new List<int>() { 2, 3 };
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
            List<int> input = new List<int>() { 2, 3, 5 };
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
            List<int> input = new List<int>() { 2, 3, 5, 7, 11 };
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
    }
}