namespace DesignPatterns.Behavioral.Command
{
    internal class PlantCommand : GardenCommand
    {
        public PlantCommand(string plant, Garden garden) : base(plant, garden)
        {
        }

        public override bool Execute()
        {
            return _garden.Add(_plant);
        }

        public override void Undo()
        {
            _garden.Remove(_plant);
        }
    }
}
