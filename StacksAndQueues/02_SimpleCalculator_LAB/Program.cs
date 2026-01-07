using System;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(" ").ToArray();
            Stack<string> tokens = new Stack<string>(expression);

            while (tokens.Any())
            {
                int firstNum = int.Parse(tokens.Pop());
                char operatorr = Convert.ToChar(tokens.Pop());
                int secondNum = int.Parse(tokens.Pop());

                switch(operatorr)
                {
                    case '+':
                    firstNum += secondNum;
                    break;
                    case '-':
                    firstNum -= secondNum;
                    break;
                    default:
                    break;
                }

                tokens.Push(firstNum.ToString());

                if (tokens.Count() == 1)
                {
                    break;
                }
            }   // 1 + 2 + 3 + 4

            Console.WriteLine(tokens.FirstOrDefault());
        }
    }
    
}