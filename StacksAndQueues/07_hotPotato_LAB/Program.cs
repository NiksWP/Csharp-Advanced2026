using System;
using System.Collections.Generic;

Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
int tosses = int.Parse(Console.ReadLine());

while (queue.Count() > 1)
{
    for (int i = 1; i < tosses; i++)       // niki gosho sasho ico
    {                                     // gosho sasho ico niki
        string currentKid = queue.Dequeue();
        queue.Enqueue(currentKid);
    }

    Console.WriteLine($"Removed {queue.Dequeue()}");
}

System.Console.WriteLine($"Last is {queue.FirstOrDefault()}");