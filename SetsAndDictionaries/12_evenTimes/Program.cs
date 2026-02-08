var n = int.Parse(Console.ReadLine());
var numbers = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    var current = int.Parse(Console.ReadLine());
    if (!numbers.ContainsKey(current))
    {
        numbers[current] = 0;
    }
    numbers[current]++;
}

var target = numbers.Where(x => x.Value % 2 == 0).FirstOrDefault();
Console.WriteLine(target.Key);