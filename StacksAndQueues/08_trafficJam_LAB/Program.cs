using System;
using System.Collections.Generic;

var capacity = int.Parse(Console.ReadLine());
var queue = new Queue<string>();
var carsPassed = 0;

string input;
while ((input = Console.ReadLine()) != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < capacity; i++)
        {
            if (queue.Count() == 0)
            {
               break;
            }

            Console.WriteLine($"{queue.Dequeue()} passed!");
            carsPassed++;
        }
    }
    else
    {
        queue.Enqueue(input);
    }
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");