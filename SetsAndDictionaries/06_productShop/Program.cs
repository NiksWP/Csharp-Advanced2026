var shops = new Dictionary<string, Dictionary<string, double>>();

string input;
while ((input = Console.ReadLine()) != "Revision")
{
    var tokens = input.Split(", ").ToArray();
    var shop = tokens[0];
    var product = tokens[1];
    var price = double.Parse(tokens[2]);

    if (!shops.ContainsKey(shop))
    {
        shops[shop] = new Dictionary<string, double>();
    }

    shops[shop].Add(product, price);
}

foreach (var shop in shops.OrderBy(x => x.Key))
{
    Console.WriteLine(shop.Key + "->");
    foreach (var kvp in shop.Value)
    {
        Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
    }
}