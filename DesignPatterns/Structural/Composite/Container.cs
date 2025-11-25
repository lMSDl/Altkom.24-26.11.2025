namespace DesignPatterns.Structural.Composite
{
    internal class Container : IComponent
    {
        public IList<IComponent> Components { get; } = new List<IComponent>();
        public string Name => GetType().Name;

        public float GetValue()
        {
            var value = Components.Sum(c => c.GetValue());
            Console.WriteLine("\tValue of {0} is {1}", Name, value);
            return value;
        }
    }
}
