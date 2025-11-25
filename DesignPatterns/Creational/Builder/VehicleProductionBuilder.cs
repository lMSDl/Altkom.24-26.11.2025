namespace DesignPatterns.Creational.Builder
{
    internal class VehicleProductionBuilder : VehicleBuilderFacade
    {
        public VehicleProductionBuilder() : this(new Vehicle())
        {
        }
        public VehicleProductionBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleProductionBuilder SetManufacturer(string manufacturer)
        {
            Vehicle.Manufacturer = manufacturer;
            return this;
        }

        public VehicleProductionBuilder SetModel(string model)
        {
            Vehicle.Model = model;
            return this;
        }

        public VehicleProductionBuilder SetYear(int year)
        {
            Vehicle.Year = year;
            return this;
        }

        public VehicleProductionBuilder SetColor(string color)
        {
            Vehicle.Color = color;
            return this;
        }
    }
}
