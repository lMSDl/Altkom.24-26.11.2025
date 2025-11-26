namespace DesignPatterns.Behavioral.State
{
    internal class CoffeeMachine
    {
        private State state;

        public State State
        {
            set
            {
                Console.WriteLine($"Zmiana stanu na {value.GetType().Name}");
                state = value;
            }
        }

        public void PowerOn()
        {
            State = new HeatingUpState(this);
        }

        public void SmallCoffee()
        {
            state.Small();
        }

        public void LargeCoffee()
        {
            state.Large();
        }
    }
}
