var n = int.Parse(Console.ReadLine());
var dict = new Dictionary<string, Dictionary<string, List<string>>>();

while (n != 0)
{
    var input = Console.ReadLine().Split().ToArray();
    var continent = input[0];
    var country = input[1];
    var city = input[2];

    if (!dict.ContainsKey(continent))
    {
        dict[continent] = new Dictionary<string, List<string>>();
    }

    if (!dict[continent].ContainsKey(country))
    {
        dict[continent][country] = new List<string>();
    }

    dict[continent][country].Add(city);
    n--;
}

foreach (var continent in dict)
{
    Console.WriteLine(continent.Key + ":");
    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}