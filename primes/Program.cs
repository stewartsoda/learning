using System;

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            // check to see if a number is prime
            for (int j = 0; j < 16; j++)
            {
                //flag for prime-ness
                bool isPrime = true;

                //pick a random int
                int num1 = new Random().Next();

                //iterate to find divisibility
                //the algorithm tries successive divisors from 2 up to (num1/2)-1 (as num1/(num1/2)=2 and should be covered by num1/2)
                //this could probably be optimized better
                for (int i = 2; i < num1 / 2; i++)
                {
                    //test to see if divides evenly, as num1%i=0 means num1 is divisible by i and therefore not prime
                    if (num1 % i == 0)
                    {
                        isPrime = false;
                        Console.WriteLine(num1 + " is not prime! It is divisible by " + i);
                        break; //don't need to test more, break out of loop for performance
                    }
                }

                //never found a number that num1 is divisible by
                if (isPrime)
                {
                    Console.WriteLine(num1 + " is prime!");
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            return;
        }
    }

}
