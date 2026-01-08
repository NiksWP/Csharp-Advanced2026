using System;
using System.Collections.Generic;

var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
var(quantity, toRemove, wanted) = (tokens[0], tokens[1], tokens[2]);

// Filling the array with numbers
var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

//Removing n numbers with method
RemoveNumbers(queue, toRemove);
if (queue.Count == 0)
{
    return;
}

CheckForElement(queue, wanted);


static void CheckForElement(Queue<int> queue, int wanted)
{
    if (queue.Contains(wanted))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}


static void RemoveNumbers(Queue<int> queue, int quantity)
{
    if (queue == null)
    {
        throw new NullReferenceException("Stack is null");
    }
    if (queue.Count == 0)
    {
        throw new InvalidOperationException("Stack is empty");
    }

    for (int i = 0; i < quantity; i++)
    {
        queue.Dequeue();
        if (queue.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }
    }
}