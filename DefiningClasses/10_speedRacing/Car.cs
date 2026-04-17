public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double travelledDistance;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.TravelledDistance = 0;
    }

    public string Model {get; set;}
    public double FuelAmount {get; set;}
    public double FuelConsumption {get; set;}
    public double TravelledDistance {get; set;}

    public void Drive(int distance)
    {
        var neededFuel = (this.fuelConsumption / 100) * distance;
        
        if (neededFuel > this.FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distance;
        }
    }
}