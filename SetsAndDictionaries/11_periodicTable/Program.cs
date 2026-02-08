var n = int.Parse(Console.ReadLine());
var set = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    var compounds = Console.ReadLine().Split().ToArray();

    for (int j = 0; j < compounds.Length; j++)
    {
     var current = compounds[j];
     set.Add(current);
    }
}

Console.WriteLine(string.Join(" ", set));