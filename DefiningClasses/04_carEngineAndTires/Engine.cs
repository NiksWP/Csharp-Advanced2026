namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cCapacity;

        public Engine(int horsePower, double cCapacity)
        {
            this.HorsePower = horsePower;
            this.CCapacity = cCapacity;
        }

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public double CCapacity
        {
            get { return cCapacity; }
            set { cCapacity = value; }
        }
    }
}