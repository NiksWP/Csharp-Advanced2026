var n = int.Parse(Console.ReadLine());
Queue<(int gas, int distance)> pumps = new Queue<(int gas, int distance)>();

for (int i = 0; i <= n - 1; i++)
{
    int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
    pumps.Enqueue((pump[0], pump[1]));
}

int tank = 0;
int startPoint = 0;

int initialCoount = pumps.Count;
for (int i = 0; i < initialCoount; i++)
{
    var currentPump = pumps.Dequeue();
    if (tank + currentPump.gas < currentPump.distance)
    {
        startPoint = i + 1;
        tank = 0;
        continue;
    }

    tank += currentPump.gas - currentPump.distance;
}

Console.WriteLine(startPoint);