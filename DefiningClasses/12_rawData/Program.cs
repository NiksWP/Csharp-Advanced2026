namespace _12_rawData
{
    public class _12_rawData
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var model = input[0];

                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoType = input[4];
                var cargoWeight = int.Parse(input[3]);
                var cargo = new Cargo(cargoType, cargoWeight);

                var tires = new List<Tire>();
                for (int j = 5; j < input.Length - 1; j += 2)
                {
                    var tireYear = input[j + 1];
                    var tirePressure = input[j];
                    tires.Add(new Tire(int.Parse(tireYear), double.Parse(tirePressure)));
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            var fragileCars = cars
                .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();

            var flammableCars = cars
                .Where(x => x.Cargo.Type == "flammable" &&
                            x.Engine.Power > 250).ToList();

            var m = Console.ReadLine();

            // foreach (var car in cars)
            // {
            //     Console.WriteLine($"{car.Model} | {car.Cargo.Type} | {car.Tires[0].Pressure}");
            // }

            if (m == "fragile")
            {
                foreach (var vehicle in fragileCars)
                {
                    Console.WriteLine(vehicle.Model);
                }
            }
            else if (m == "flammable")
            {
                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}