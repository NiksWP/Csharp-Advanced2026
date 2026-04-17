Dictionary<string, Car> cars = new Dictionary<string, Car>();
var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
     var carInfo = Console.ReadLine().Split();
     var model = carInfo[0];
     var fuelAmount = double.Parse(carInfo[1]);
     var fuelConsumption = double.Parse(carInfo[2]);

     Car car = new Car(model, fuelAmount, fuelConsumption);
     
     if (!cars.ContainsKey(model))
     {
        cars.Add(model, car);
     }
}
string input;
while ((input = Console.ReadLine()) != "End")
{
    var tokens = input.Split();
    if (tokens[0].ToLower() != "drive")
    {
        continue;
    }

    // NB.   COULD LEAD TO ERROR! MIGHT NEED VERIFICATION
    var carModel = tokens[1];
    var amountOfKm = int.Parse(tokens[2]);

    cars[carModel].Drive(amountOfKm);
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TraveledDistance}");
}

// foreach (var car in cars)
// {
//     Console.WriteLine(car.Key);
//     Console.WriteLine(car.Value.TraveledDistance);
//     Console.WriteLine(car.Value.FuelAmount);
// }