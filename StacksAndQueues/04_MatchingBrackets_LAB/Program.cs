using System;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();
            Stack<string> brackets = new Stack<string>();

            for (int i = 0; i < expression.Length; i++)
            {
                char current = expression[i];
                if(current == '(')
                {
                    indexes.Push(i);
                }

                if (current == ')')
                {
                    int startIndex = indexes.Pop();
                    string bracket = expression.Substring(startIndex, i - startIndex + 1);
                    brackets.Push(bracket);
                }
            }
            foreach (string bracket in brackets)
            {
                Console.WriteLine(bracket);
            }
        }
    }
}