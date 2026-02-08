var n = int.Parse(Console.ReadLine());
var names = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    var name = Console.ReadLine();
    names.Add(name);
}

Console.WriteLine(String.Join("\n", names));