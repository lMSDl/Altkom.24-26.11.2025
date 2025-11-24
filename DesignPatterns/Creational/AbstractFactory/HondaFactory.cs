namespace DesignPatterns.Creational.AbstractFactory
{
    internal class HondaFactory : ISedanFactory, ISuvFactory
    {
        public ISedan CreateSedan(string segment)
        {
            return segment switch
            {
                "Compact" => new HondaCompactSedan(),
                "Full" => new HondaFullSedan(),
                _ => throw new ArgumentException("Invalid segment", nameof(segment)),
            };
        }


        public ISuv CreateSuv(string segment)
        {
            return segment switch
            {
                "Compact" => new HondaCompactSuv(),
                "Full" => new HondaFullSuv(),
                _ => throw new ArgumentException("Invalid segment", nameof(segment)),
            };
        }
    }
}
