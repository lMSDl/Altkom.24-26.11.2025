namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public void SetWheels(int wheels)
        {
            _vehicle.Wheels = wheels;
        }
        public void SetSeats(int seats)
        {
            _vehicle.Seats = seats;
        }
        public void SetDoors(int doors)
        {
            _vehicle.Doors = doors;
        }
        public void SetTrunkCapacity(int trunkCapacity)
        {
            _vehicle.TrunkCapacity = trunkCapacity;
        }
        public void SetEnginePower(int enginePower)
        {
            _vehicle.EnginePower = enginePower;
        }
        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
