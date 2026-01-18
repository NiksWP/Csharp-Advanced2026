var queue = new Queue<string>(Console.ReadLine().Split(", ").ToArray());

while (queue.Any())
{
 string[] input = Console.ReadLine().Split(" ", 2);
 string command = input[0];
 string song = input.Length > 1 ? input[1] : null;

    if (command == "Play")
    {
        queue.Dequeue();
        if (!queue.Any())
        {
            Console.WriteLine("No more songs!");
            break;
        }
    }
    else if (command == "Add")
    {
        if (!queue.Contains(song))
        {
            queue.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (input[0] == "Show")
    {
        Console.WriteLine(String.Join(", ", queue));
    }
}