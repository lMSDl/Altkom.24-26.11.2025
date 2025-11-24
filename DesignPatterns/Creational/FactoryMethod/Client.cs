using DesignPatterns.Creational.FactoryMethod.ClientOperations;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            //var elevator = new Elevator();
            var elevator = new HorizontalElevator();
            var request = new Request("GOTO", 5);
            
            elevator.Execute(request.Operation, request.Floor);

            elevator.Execute(request.Operation, request.Floor);


            request = new Request("LEFT", 5);
            elevator.Execute(request.Operation, request.Floor);

        }

    }
    record Request(string Operation, int Floor);


    class HorizontalElevator : Elevator
    {
        protected override IElevatorOperation? CreateOperation(string operation)
        {

            switch (operation.ToUpper())
            {
                case "LEFT":
                    return new ElevatorLeft();
                case "RIGHT":
                    return new ElevatorRight();
                default:
                    return null;
            }
            return base.CreateOperation(operation);
        }
    }
}
