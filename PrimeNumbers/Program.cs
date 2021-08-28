using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetInputNumber();
            HashSet<int> primes = PrimeGenerator.Generate(num);
            List<List<int>> mulPrimes = HelperFunctions.MultiplyPrimes(primes);
            PrintPrimes(primes);
            PrintMulTable(mulPrimes);
            Console.ReadLine();
        }
        private static void PrintMulTable(List<List<int>> mulPrimes)
        {
            Console.WriteLine("\n\nPrime Multiplication Table.\n");
            for (int row = 0; row < mulPrimes.Count; row++)
            {
                for (int col = 0; col < mulPrimes.Count; col++)
                {
                    Console.Write("{0} ", mulPrimes[row][col]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintPrimes(HashSet<int> primes)
        {
            Console.WriteLine("Prime Numbers.\n");
            foreach (int prime in primes)
            {
                Console.Write("{0} ", prime);
            }
        }
        private static int GetInputNumber()
        {
            string value = "";
            int num = 0;
            while (!(int.TryParse(value, out num) && num >= 1))
            {
                Console.WriteLine("input a whole number N, where is N is at least 1");
                value = Console.ReadLine();
            }
            return num;
        }
    }
}
