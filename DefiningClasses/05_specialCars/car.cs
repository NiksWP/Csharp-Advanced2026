using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double neededFuel = (distance / 100) * this.FuelConsumption;

            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;
            }
        }
    }
}

// using System.Text;


// namespace CarManufacturer
// {
//     class Car
//     {
//         // CONSTRUCTORS
//         public Car()
//         {
//             this.Make = "VW";
//             this.Model = "Golf";
//             this.Year = 2025;
//             this.FuelQuantity = 220;
//             this.FuelConsumption = 10;
//         }

//         public Car(string make, string model, int year) : this()
//         {
//             this.Make = make;
//             this.Model = model;
//             this.Year = year;
//         }

//         public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
//         {
//             this.FuelQuantity = fuelQuantity;
//             this.FuelConsumption = fuelConsumption;
//         }

//         public Car (string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
//         {
//             this.Engine = engine;
//             this.Tires = tires;
//         }

//         // FIELDS
//         private string make;
//         private string model;
//         private int year;
//         private double fuelQuantity;
//         private double fuelConsumption;

//         private Engine engine;
//         private Tire[] tires;

//         // PROPERTIES
//         public string Make
//         {
//             get
//             {
//                 return make;
//             }
//             set
//             {
//                 if (value == "")
//                 {
//                     throw new Exception("invalid input");
//                 }

//                 make = value;
//             }
//         }

//         public string Model
//         {
//             get
//             {
//                 return model;
//             }
//             set
//             {
//                 if (value == "")
//                 {
//                     throw new Exception("invalid input");
//                 }

//                 model = value;
//             }
//         }

//         public int Year
//         {
//             get
//             {
//                 return year;
//             }
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new Exception("invalid input");
//                 }

//                 year = value;
//             }
//         }

//         public double FuelQuantity
//         {
//             get;
//             set;
//         }

//         public double FuelConsumption
//         {
//             get;
//             set;
//         }

//         public Engine Engine
//         {
//             get;
//             set;
//         }

//         public Tire[] Tires
//         {
//             get;
//             set;
//         }
//         //FUNCTIONS
//         public void Drive(double distance)
//         {
//             double neededFuel = distance / 100 * this.FuelConsumption;

//             if (this.FuelQuantity - neededFuel <= 0)
//             {              
//                   Console.WriteLine("Not enough fuel to perform this trip!");
//             }
//             else
//             {
//                 this.FuelQuantity -= neededFuel;
//             }
//         }

//         public string WhoAmI()
//         {
//             StringBuilder sb = new StringBuilder();
//             sb.AppendLine($"Make: {this.Make}");
//             sb.AppendLine($"Model: {this.Model}");
//             sb.AppendLine($"Year: {this.Year}");
//             sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
//             sb.AppendLine($"FuelQuantity: {this.FuelQuantity:0.##}");

//             return sb.ToString();
//         }
//     }
// }