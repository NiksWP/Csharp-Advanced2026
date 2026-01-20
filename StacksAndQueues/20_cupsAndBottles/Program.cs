var cups = new Queue<int>(Console.ReadLine()
.Split().Select(int.Parse).ToArray());
var bottles = new Stack<int>(Console.ReadLine()
.Split().Select(int.Parse).ToArray());
var wastedWater = 0;
var remainingCup = 0;

while (true)
{
    var cup = cups.Dequeue();

    while (cup > 0)
    {
        var bottle = bottles.Pop();
        if (bottle - cup == 0)
        {
            break;
        }
        else if (bottle > cup)
        {
            wastedWater += bottle - cup;
            break;
        }
        else
        {
            cup -= bottle;
        }
    }

    if (!cups.Any())
    {
        Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
        break;
    }
    else if (!bottles.Any())
    {
        Console.WriteLine($"Cups: {string.Join(" ", cups)}");
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
        break;
    }
}