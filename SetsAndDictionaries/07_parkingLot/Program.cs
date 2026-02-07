var parking = new HashSet<string>();

var empty = false;
string input;
while ((input = Console.ReadLine()) != "END")
{
    var tokens = input.Split(", ").ToArray();
    var car = tokens[1];

    if (tokens[0] == "IN")
    {
        parking.Add(car);
    }
    else if (tokens[0] == "OUT")
    {
        if (!parking.Any())
        {
            empty = true;
            break;
        }
        parking.Remove(car);
    }
    else continue;
}

if (empty == false && parking.Any())
{
    Console.WriteLine(String.Join("\n", parking));
    return;
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
