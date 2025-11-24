namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);
            vehicle = new Vehicle(wheels: 4, seats: 5, doors: 4, trunkCapacity: 500, enginePower: 100);

            //var vehicleBuilder = new Vehicle.VehicleBuilder().Build();

            Console.WriteLine(vehicle);


            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWheels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetDoors(4);
            vehicleBuilder.SetTrunkCapacity(500);
            vehicleBuilder.SetEnginePower(100);
            vehicle = vehicleBuilder.Build();

            Console.WriteLine(vehicle);


            vehicle = new Vehicle() { Wheels = 4, Seats = 5, TrunkCapacity = 500, Doors = 4, EnginePower = 100 };
            Console.WriteLine(vehicle);
        }
    }
}
