namespace DesignPatterns.Creational.FactoryMethod.ClientOperations
{
    internal class ElevatorLeft : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will stop at station {floor} going LEFT");
        }
    }
}
