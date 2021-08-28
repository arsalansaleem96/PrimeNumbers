using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetInputNumber();
            List<int> primes = PrimeGenerator.Generate(num);
            List<List<int>> mulPrimes = HelperFunctions.MultiplyPrimes(primes);
            PrintPrimes(primes);
            PrintMulTable(mulPrimes);
            Console.ReadLine();
        }
        private static void PrintMulTable(List<List<int>> list)
        {
            Console.WriteLine("\n\nPrime Multiplication Table.\n");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    Console.Write("{0} ", list[i][j]);
                }
                Console.WriteLine();
            }
        }
        private static void PrintPrimes(List<int> primes)
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
