using System;
using System.Collections;

namespace piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sl = new ArrayList();
            sl.Add("This is a test sentence.");
            sl.Add("I love Pig Latin!");
            sl.Add("Magnets... how do they work?");
            sl.Add("This sentence is a run-on and will be more difficult.");
            sl.Add("Pig Latin is cool");


            foreach (String s in sl)
            {
                Console.WriteLine("Input string:   " + s);
                Console.WriteLine("Output string:  " + PigIt(s));
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }

        public static string PigIt(string str)
        {
            string outString = "";
            char[] chars = str.ToCharArray();

            Stack s = new Stack();
            Queue q = new Queue();

            bool isFirst = true;

            foreach (char c in chars)
            {
                if (isFirst)//at the beginning of a word
                {
                    if (char.IsWhiteSpace(c) || char.IsPunctuation(c))//a punctuation mark at the beginning of the word
                    {
                        outString = outString + c;
                    }
                    else
                    {
                        s.Push(c);
                        isFirst = false;
                    }
                }
                else if (char.IsWhiteSpace(c) || char.IsPunctuation(c))//at the end of a word
                {
                    //add everything in q
                    foreach (char c2 in q)
                    {
                        outString = outString + c2;
                    }
                    //add the stuff in s
                    foreach (char c2 in s)
                    {
                        outString = outString + c2;
                    }
                    outString = outString + "ay";
                    //add c
                    outString = outString + c;
                    isFirst = true;
                    q.Clear();
                    s.Clear();
                }
                else
                {
                    q.Enqueue(c);
                }

            }
            if (q.Count != 0 || s.Count != 0)
            {
                foreach (char c2 in q)
                {
                    outString = outString + c2;
                }
                //add the stuff in s
                foreach (char c2 in s)
                {
                    outString = outString + c2;
                }
                outString = outString + "ay";
            }
            return outString;

        }
    }
}