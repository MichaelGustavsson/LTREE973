namespace Yield;

class Program
{
    static void Main()
    {
        Console.WriteLine("Let's start the fun work!");
        Console.WriteLine("---------------------------------");

        var vehicles = VehicleRepository.ListAllVehicles().Skip(2).Take(1);

        Console.WriteLine("Starting the foreach...");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Fetched {vehicle}");
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Now the fun is over!!!");
    }
}


