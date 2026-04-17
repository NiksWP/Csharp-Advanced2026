var n = int.Parse(Console.ReadLine());
var cars = new Dictionary<string, Car>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().ToArray();

    var model = input[0];
    var fuelAmount = double.Parse(input[1]);
    var fuelConsumption = double.Parse(input[2]);

    if (!cars.ContainsKey(model))
    {
        cars.Add(model, new Car(model, fuelAmount, fuelConsumption));
    }
}

string inputt;
while ((inputt = Console.ReadLine()) != "End")
{
    var tokens = inputt.Split();
    var car = tokens[0];
    var distance = int.Parse(tokens[1]);
    cars[car].Drive(distance);
}

foreach (var car in cars)
{
    Console.WriteLine(car.Key + " " + car.Value.FuelAmount + " " + car.Value.TravelledDistance);
}