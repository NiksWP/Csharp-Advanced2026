using System;
using System.Data.Common;

namespace _02_stackSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (string.IsNullOrEmpty(command))
                {
                    break;
                }
                string[] tokens = command.Split();

                if(tokens[0].ToLower() == "add")
                {
                    var firstNum = tokens[1];
                    stack.Push(int.Parse(firstNum));
                    if (tokens.Count() > 2)
                    {
                    var secondNum = tokens[2];
                    stack.Push(int.Parse(secondNum));
                    }
                }
                else if(tokens[0].ToLower() == "remove")
                {
                    int numbersToRemove = int.Parse(tokens[1]);
                    if (numbersToRemove > stack.Count())
                    {
                        stack.Clear();
                    }

                    for (int i = 0; i < numbersToRemove; i++)
                    {
                        stack.Pop();
                    }

                }
            }

            int sum = 0;
            foreach (int num in stack)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}