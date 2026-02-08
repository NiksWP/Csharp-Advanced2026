var n = int.Parse(Console.ReadLine());
var wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" -> ").ToArray();
    var color = input[0];
    var clothes = input[1].Split(",").ToArray();

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe[color] = new Dictionary<string, int>();
    }

    for (int j = 0; j < clothes.Length; j++)
    {
        var cloth = clothes[j];

        if (!wardrobe[color].ContainsKey(cloth))
        {
            wardrobe[color][cloth] = 0;
        }
        wardrobe[color][cloth]++;
    }
}
var target = Console.ReadLine().Split().ToArray();

var additive = " (found!)";
foreach (var kvp in wardrobe)
{
    Console.WriteLine($"{kvp.Key} clothes:");
    foreach (var cloth in kvp.Value)
    {
        var result = $"* {cloth.Key} - {cloth.Value}";
        if (target[0] == kvp.Key && target[1] == cloth.Key)
        {
           result += additive;
        }
        Console.WriteLine(result);
    }
}