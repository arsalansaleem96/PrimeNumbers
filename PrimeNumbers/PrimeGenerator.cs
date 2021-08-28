using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeGenerator
    {
        public static HashSet<int> Generate(int n)
        {
            HashSet<int> primes = new HashSet<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;

                foreach (int prime in primes)
                {
                    if (prime <= sqrt)
                    {
                        if (nextPrime % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
    }
}
