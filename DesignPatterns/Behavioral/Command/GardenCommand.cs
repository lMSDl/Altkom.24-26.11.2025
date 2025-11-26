namespace DesignPatterns.Behavioral.Command
{
    internal abstract class GardenCommand : ICommand
    {
        protected readonly string _plant;
        protected readonly Garden _garden;

        public GardenCommand(string plant, Garden garden)
        {
            _plant = plant;
            _garden = garden;
        }

        public abstract bool Execute();
        public abstract void Undo();
    }
}
