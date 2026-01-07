var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
var queue = new Queue<int>();
var flag = 1;

foreach (var number in numbers)
{
    if (flag % 2 == 0)
    {
        queue.Enqueue(number);
    }
    flag++;
}

Console.WriteLine(String.Join(", ", queue));