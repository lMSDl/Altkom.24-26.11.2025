namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public VehicleBuilder SetWheels(int wheels)
        {
            _vehicle.Wheels = wheels;
            return this;
        }
        public VehicleBuilder SetSeats(int seats)
        {
            _vehicle.Seats = seats;
            return this;
        }
        public VehicleBuilder SetDoors(int doors)
        {
            _vehicle.Doors = doors;
            return this;
        }
        public VehicleBuilder SetTrunkCapacity(int trunkCapacity)
        {
            _vehicle.TrunkCapacity = trunkCapacity;
            return this;
        }
        public VehicleBuilder SetEnginePower(int enginePower)
        {
            _vehicle.EnginePower = enginePower;
            return this;
        }
        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
