public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKilometer = fuelConsumption;
    }
    public string Model {get; set;}
    public double FuelAmount{get; set;}
    public double FuelConsumptionPerKilometer{get;set;}
    public double TraveledDistance {get; set;} = 0;

    public void Drive(int km)
    {
        var neededFuel = this.FuelConsumptionPerKilometer * km;
        if (neededFuel <= this.FuelAmount)
        {
            this.TraveledDistance += km;
            this.FuelAmount -= neededFuel;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}