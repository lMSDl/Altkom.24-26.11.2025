
namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        public void Execute(IElevatorOperation? operation, int floor)
        {
            operation?.Operate(floor);
        }

        public void Execute(string operation, int floor)
        {
            Execute(CreateOperation(operation), floor);
        }

        private Dictionary<string, IElevatorOperation> _operations = [];

        protected virtual IElevatorOperation? CreateOperation(string operation)
        {
            if (_operations.TryGetValue(operation, out var result))
            {
                return result;
            }

            result = operation.ToUpper() switch
            {
                "UP" => new ElevatorUp(),
                "DOWN" => new ElevatorDown(),
                "GOTO" => new ElevatorGoTo(),
                _ => null
            };

            if (result is not null)
            {
                _operations[operation] = result;
            }

            return result;
        }
    }
}
