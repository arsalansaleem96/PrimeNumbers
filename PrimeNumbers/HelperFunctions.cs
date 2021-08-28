using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class HelperFunctions
    {
        public static List<List<int>> MultiplyPrimes(HashSet<int> primes)
        {
            List<List<int>> table = new List<List<int>>();
            foreach(int i in primes)
            {
                List<int> newList = new List<int>();
                foreach (int j in primes)
                {
                    int product = i * j;
                    newList.Add(product);
                }
                table.Add(newList);
            }
            return table;
        }
    }
}
