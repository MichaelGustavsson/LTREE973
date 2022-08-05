namespace Yield;
public class VehicleModel
{
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public VehicleModel(string make, string model)
    {
        Make = make;
        Model = model;
        Console.WriteLine($"Instantiated the vehicle {Make} {Model}");
    }

    public override string ToString()
    {
        return $"{Make} {Model}";
    }
}