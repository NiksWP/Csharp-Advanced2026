namespace _12_rawData
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
            this.Age = year;
            this.Pressure = pressure;
        }
        public int Age {get; set;}
        public double Pressure {get; set;}
    }
}