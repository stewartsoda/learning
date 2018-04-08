using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to test as a palindrome: ");
            string test = "barferino";// Console.ReadLine();
            test.ToLower();
            char[] strA = test.ToCharArray();
            char[] strB = new char[strA.Length];
            for (int i = 0; i < strA.Length; i++)
            {
                strB[i] = strA[strA.Length - i - 1];
            }

            if (String.Equals(new String(strA), new String(strB)))
            {
                Console.WriteLine(test + " is a palindrome!");
            }
            else
            {
                Console.WriteLine(test + " is not a palindrome.");
            }
        }
    }
}
