var vip = new HashSet<string>();
var regular = new HashSet<string>();

string guests;
while ((guests = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(guests[0]))
    {
        vip.Add(guests);
    }
    else
    {
        regular.Add(guests);
    }
}

var count = vip.Count + regular.Count;

string input;
while ((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        vip.Remove(input);
    }
    else
    {
        regular.Remove(input);
    }
}

Console.WriteLine(vip.Count + regular.Count);
foreach (var guest in vip)
{
    Console.WriteLine(guest);
}

foreach (var guest in regular)
{
    Console.WriteLine(guest);
}