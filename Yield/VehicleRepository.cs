namespace Yield;
public class VehicleRepository
{
    public static IEnumerable<VehicleModel> ListAllVehicles()
    {
        // return new List<VehicleModel>{
        //     new VehicleModel("Volvo", "V90"),
        //     new VehicleModel("BMW", "X3"),
        //     new VehicleModel("Mercedes", "AMG"),
        //     new VehicleModel("Ford", "Mustang"),
        //     new VehicleModel("Audi", "Q6")
        // };

        yield return new VehicleModel("Volvo", "V90");
        yield return new VehicleModel("BMW", "X3");
        yield return new VehicleModel("Mercedes", "AMG");
        yield return new VehicleModel("Ford", "Mustang");
        yield return new VehicleModel("Audi", "Q6");
    }
}