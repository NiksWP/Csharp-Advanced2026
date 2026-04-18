using System.Reflection.Metadata.Ecma335;

namespace _13_carSalesman
{
    public class _13_carSalesman
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var engines = new Dictionary<string, Engine>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine engine;

                var engineModel = input[0];
                var enginePower = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    var engineDisplacement = int.Parse(input[2]);
                    var engineEfficiency = input[3];
                    engines.Add(engineModel, new Engine(engineModel, enginePower, engineEfficiency, engineDisplacement));
                }
                else if (input.Length == 3)
                {
                    bool isDisplacement = int.TryParse(input[2], out int displacement);
                    if (isDisplacement)
                    {
                        engines.Add(engineModel, new Engine(engineModel, enginePower, displacement));
                    }
                    else
                    {
                        engines.Add(engineModel, new Engine(engineModel, enginePower, input[2]));
                    }
                }
                else
                {
                    engines.Add(engineModel, new Engine(engineModel, enginePower));
                }
            }

            var m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car;

                var carModel = input[0];
                var carEngine = input[1];

                if (input.Length == 4)
                {
                    var carWeight = int.Parse(input[2]);
                    var carColor = input[3];
                    cars.Add(new Car(carModel, engines[carEngine], carWeight, carColor));
                }
                else if(input.Length == 3)
                {
                    bool isWeight = int.TryParse(input[2], out int weight);
                    if (isWeight)
                    {
                        cars.Add(new Car(carModel, engines[carEngine], weight));
                    }
                    else
                    {
                        cars.Add(new Car(carModel, engines[carEngine], input[2]));
                    }
                }
                else
                {
                    cars.Add(new Car(carModel, engines[carEngine]));
                }
            }

            foreach (var vehicle in cars)
            {
                Console.WriteLine($"{vehicle.Model}:");
                Console.WriteLine($"  {vehicle.Engine.Model}:");
                Console.WriteLine($"    Power: {vehicle.Engine.Power}");
                if (vehicle.Engine.Displacement == 0)
                {
                    Console.WriteLine("   Displacement: n/a");
                }
                else
                {
                   Console.WriteLine($"    Displacement: {vehicle.Engine.Displacement}");   
                }
                Console.WriteLine($"    Efficiency: {vehicle.Engine.Efficiency}");
                if (vehicle.Weight == 0)
                {
                Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                Console.WriteLine($"  Weight: {vehicle.Weight}");   
                }
                Console.WriteLine($"  Color: {vehicle.Color}");
            }
        }
    }
}