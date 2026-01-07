using System;
using System.Collections.Generic;

Queue<string> queue = new Queue<string>();
string input;
while ((input = Console.ReadLine()) != "end")
{
    if(input == "Paid")
    {
        Console.WriteLine(string.Join("\n", queue));
        queue.Clear();
    }
    else
    {
        queue.Enqueue(input);
    }
}

Console.WriteLine($"{queue.Count} people remaining.");