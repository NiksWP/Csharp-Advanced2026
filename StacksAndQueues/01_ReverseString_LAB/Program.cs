using System;
using System.Collections.Generic;

namespace _01_reverseString
{
    class Program
   {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char letter in input)
            {
                stack.Push(letter);
            }

            foreach (char letter in stack)
            {
                Console.Write(letter);
            }
        }
    }
}