namespace SOLID.L
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        //public abstract void Fly();
        public abstract void Move();
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying at 30,000 feet.");
        }
        public override void Move()
        {
            Fly();
        }
    }

    class Helicopter : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} is hovering at 10,000 feet.");
        }
        public override void Move()
        {
            Fly();
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} is driving on the road.");
        }
    }
}
