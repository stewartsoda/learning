using System;
using System.Collections;

namespace printprimes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Input: user specifies n: the number of primes to print.
            Output: print the first n primes. 
            */

            Console.WriteLine("Please enter the number of primes you wish to print:");

            int number = Convert.ToInt32(Console.ReadLine());
            //int number = 1000000;

            ArrayList primeList = new ArrayList();

            /*
            the best way to do this so I'm not calculating the same numbers over and over
            is to count the number of primes as I go and just start counting up
            */

            int currentNum = 2;
            while (primeList.Count < number)
            {
                if (isPrime(currentNum))
                {
                    primeList.Add(currentNum);
                    Console.WriteLine(currentNum);
                }
                currentNum++;
            }

            //foreach (int num in primeList)
            //{
            //    Console.WriteLine(num);
            //}

            return;
        }

        private static bool isPrime(int num)
        {
            bool primeness = true;
            if (num < 2)
            {
                primeness = false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    primeness = false;
                    break;
                }
            }
            return primeness;
        }
    }
}
