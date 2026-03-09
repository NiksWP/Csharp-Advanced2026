using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("invalid input");
                }

                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("invalid input");
                }

                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("invalid input");
                }

                year = value;
            }
        }

        public double FuelQuantity
        {
            get;
            set;
        }

        public double FuelConsumption
        {
            get;
            set;
        }

       public string Drive(double distance)
        {
            if (this.fuelQuantity - (distance * this.fuelConsumption) > 0)
            {
                return "Done";
            }

            return "Not enough fuel to perform the trip!";
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return sb.ToString();
        }
    }
}