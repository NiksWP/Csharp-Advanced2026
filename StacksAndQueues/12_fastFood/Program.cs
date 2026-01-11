int totalFood = int.Parse(Console.ReadLine());
Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Console.WriteLine(orders.Max());

while (true)
{
    int currentOrder = orders.Peek();

    if (totalFood - currentOrder >= 0)
    {
        totalFood -= currentOrder;
        orders.Dequeue();
        if (!orders.Any())
        {
           Console.WriteLine("Orders complete");
           break;
        }
    }
    else
    {
        Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
        break;
    }

    if (!orders.Any())
    {
        Console.WriteLine("Orders complete");
        break;
    }
}