int n = int.Parse(Console.ReadLine());
var hashset = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    var name = Console.ReadLine();

    if (!hashset.Contains(name))
    {
        hashset.Add(name);
    }
}

Console.WriteLine();

foreach (var name in hashset)
{
    Console.WriteLine(name);
}