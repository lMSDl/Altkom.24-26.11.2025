namespace DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BaseBuilder<Vehicle>
    {
        public VehicleBuilderFacade() : this(new Vehicle())
        {
        }
        public VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Parts => new VehicleBuilder();
        public VehicleProductionBuilder Production => new VehicleProductionBuilder();
    }
}
