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
            foreach (char letter in input)
            {
                stackк.Push(letter);
            }

            foreach (char letter in stackк)
            {
                Console.Write(letter);
            }
        }
    }
}