var stack = new Stack<int>();
int n = int.Parse(Console.ReadLine());

while (true)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (input[0] == 1)
    {
        stack.Push(input[1]);
    }
    else if(input[0] == 2 && stack.Any())
    {
        stack.Pop();
    }
    else if (input[0] == 3 && stack.Any())
    {
        Console.WriteLine(stack.Max());
    }
    else if (input[0] == 4 && stack.Any())
    {
        Console.WriteLine(stack.Min());
    }

    n--;
    if (n == 0)
    {
        break;
    }
}

Console.WriteLine(string.Join(", ", stack));