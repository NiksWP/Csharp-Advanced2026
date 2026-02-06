var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
var dictionary = new Dictionary<double, int>();

foreach (var number in input)
{
    if (!dictionary.Keys.Contains(number))
    {
        dictionary.Add(number, 1);
        continue;
    }
    dictionary[number]++;
}

foreach (var entry in dictionary)
{
    Console.WriteLine(entry.Key + " - " + entry.Value + " times");
}