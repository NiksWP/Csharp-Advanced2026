using System.Globalization;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new List<List<Tire>>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var set = new List<Tire>();
                for (int i = 0; i < tokens.Length; i+= 2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1], CultureInfo.InvariantCulture);
                    set.Add(new Tire(year, pressure));
                }

                tires.Add(set);
                
            }

            string engineInput;
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                var tokens = engineInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 2 || !int.TryParse(tokens[0], out int horsepower) || !double.TryParse(tokens[1], out double cubicCapacity))
                {
                    continue;
                }

                engines.Add(new Engine(horsepower, cubicCapacity));
            }

            string carInput;
            while ((carInput = Console.ReadLine()) != "Show special")
            {
                var tokens = carInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = tokens[0], model = tokens[1];
                int year = int.Parse(tokens[2]), engineIndex = int.Parse(tokens[5]), tireIndex = int.Parse(tokens[6]);
                double fuelQuantity = double.Parse(tokens[3]), fuelConsumption = double.Parse(tokens[4]);
                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex].ToArray()));
            }

            foreach (var car in cars)
            {
                car.Drive(20);
            }

            var specialCars = cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.Tires.Sum(t => t.Pressure) >= 9 && x.Tires.Sum(t => t.Pressure) <= 10).ToList();

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}

