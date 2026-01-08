using System;
using System.Collections.Generic;
using System.Data;

var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
var(quantity, toRemove, searched) = (tokens[0], tokens[1], tokens[2]);
bool flag = false;
var smallest = int.MaxValue;


var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
var stack = new Stack<int>(numbers);

RemoveNumbers(stack, toRemove);


var arr = stack.ToArray();
foreach (int num in arr)
{
    if (num == searched)
    {
        flag = true;
    }
    if (num <= smallest)
    {
        smallest = num;
    }
}

if (flag)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(smallest);
}


static void RemoveNumbers(Stack<int> stack, int numbers)
{
    if (stack == null)
    {
        throw new NullReferenceException("Stack is null");
    }
    if (stack.Count == 0)
    {
        throw new InvalidOperationException("Stack is empty");
    }

    if (stack.Any())
    {
        for (int i = 0; i < numbers; i++)
        {
            stack.Pop();
            if (stack.Count() == 0)
            {
                Console.WriteLine("o");
                return;
            }
        }
    }
}