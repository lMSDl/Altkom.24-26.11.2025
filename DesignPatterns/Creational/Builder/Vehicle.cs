namespace DesignPatterns.Creational.Builder;
internal class Vehicle : ICloneable
{

    // Builder często występuje jako klasa zagnieżdżona
    // tutaj pokazano szkic implementacji wzorca Builder
    // wymaga on zablokowania konstruktora klasy Vehicle (private), dzięki czemu builder jest jedynym sposobem tworzenia obiektów tej klasy
    /*public class VehicleBuilder()
    {
        private Vehicle _vehicle = new Vehicle();

        public Vehicle Build()
        {
            return _vehicle;
        }
    }

    private Vehicle()
    {
    }*/

    public Vehicle()
    {
    }

    public Vehicle(int wheels, int seats)
    {
        Wheels = wheels;
        Seats = seats;
    }

    public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
    {
        TrunkCapacity = trunkCapacity;
    }

    public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
    {
        EnginePower = enginePower;
    }

    public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats)
    {
        Doors = doors;
        TrunkCapacity = trunkCapacity;
        EnginePower = enginePower;
    }


    public int Wheels { get; set; }
    public int Seats { get; set; }
    public int Doors { get; set; }
    public int? TrunkCapacity { get; set; }
    public int? EnginePower { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Wheels: {Wheels}, Seats: {Seats}, Doors: {Doors}, Trunk Capacity: {TrunkCapacity ?? 0}L, Engine Power: {EnginePower ?? 0}HP";
    }
}

