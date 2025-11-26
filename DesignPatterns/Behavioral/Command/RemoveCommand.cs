namespace DesignPatterns.Behavioral.Command
{
    internal class RemoveCommand : GardenCommand
    {
        public RemoveCommand(string plant, Garden garden) : base(plant, garden)
        {
        }
        public override bool Execute()
        {
            return _garden.Remove(_plant);
        }

        public override void Undo()
        {
            _garden.Add(_plant);
        }
    }
}
