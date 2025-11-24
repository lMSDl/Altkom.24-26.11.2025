namespace DesignPatterns.Creational.FactoryMethod.ClientOperations
{
    internal class ElevatorRight : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will stop at floor {floor} going LEFT");
        }
    }
}
