var input = Console.ReadLine();
var symbols = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    var current = input[i];
    if (!symbols.ContainsKey(current))
    {
        symbols[current] = 0;
    }
    symbols[current]++;
}

foreach (var kvp in symbols.OrderBy(x => x.Key))
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
}