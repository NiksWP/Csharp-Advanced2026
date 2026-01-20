var bulletPrice = int.Parse(Console.ReadLine());
var magazine = int.Parse(Console.ReadLine());
var bullets = new Stack<int>(Console.ReadLine().Split()
.Select(int.Parse).ToArray());
var locks = new Queue<int>(Console.ReadLine().Split().Select
(int.Parse).ToArray());
var chest = int.Parse(Console.ReadLine());

var barrel = magazine;

while (bullets.Any() && locks.Any())
{
    var bullet = bullets.Pop();
    chest -= bulletPrice;
    var _lock = locks.Peek();

    if (bullet <= _lock)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    barrel--;
    if (barrel == 0 && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        barrel = magazine;
    }

}

if (!bullets.Any() && locks.Any())
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}
else if (!locks.Any())
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${chest}");
}
