using Microsoft.VisualBasic;

var sides = new Dictionary<string, HashSet<string>>();
var people = new Dictionary<string, string>();

string input;
while ((input = Console.ReadLine()) != "Lumpawaroo")
{
    if (input.Contains("|"))
    {
        var tokens = input.Split(" | ").ToArray();
        var side = tokens[0];
        var name = tokens[1];

        if (!sides.ContainsKey(side))
        {
            sides[side] = new HashSet<string>();
        }
        sides[side].Add(name);

        people[name] = side;
    }
    else if (input.Contains(" -> "))
    {
        var tokens = input.Split(" -> ").ToArray();

        var name = tokens[0];
        var side = tokens[1];

        if (!sides.ContainsKey(side))
        {
            sides[side] = new HashSet<string>();
        }

        if (people.ContainsKey(name))
        {
            var removeFrom = people[name];
            sides[removeFrom].Remove(name);
        }
        //var removeFrom = people[name];
        //sides[removeFrom].Remove(name);
        people[name] = side;
        sides[side].Add(name);

        Console.WriteLine($"{name} joins the {side} side!");
    }
}

foreach (var side in sides.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
    foreach (var person in side.Value.OrderBy(x => x))
    {
        Console.WriteLine("! " + person);
    }
}