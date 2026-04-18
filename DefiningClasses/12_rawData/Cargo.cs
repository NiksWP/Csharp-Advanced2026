namespace _12_rawData
{
    public class Cargo
    {
        public Cargo(string type, int eight)
        {
            this.Type = type;
            this.Weight = eight;
        }
        public string Type {get; set;}
        public int Weight {get; set;}
    }
}