using System;
using System.Collections.Generic;

namespace _01_reverseString
{
    class Program
   {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stackк = new Stack<char>();
            foreach (char letterr in input)
            {
                stackк.Push(letterr);
            }

            foreach (char letterr in stackк)
            {
                Console.Write(letterr);
            }
        }
    }
}