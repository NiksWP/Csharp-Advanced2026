namespace _13_carSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, int displaccement) : this(model, power)
        {
            this.Displacement = displaccement;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, string efficiency, int displaccement) : this(model, power)
        {
            this.Efficiency = efficiency;
            this.Displacement = displaccement;
        }
        public string Model{get; set;}
        public int Power{get; set;}
        public int Displacement{get; set;}
        public string Efficiency{get; set;}
    }
}