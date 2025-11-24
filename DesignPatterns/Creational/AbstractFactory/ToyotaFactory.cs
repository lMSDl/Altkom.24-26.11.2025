namespace DesignPatterns.Creational.AbstractFactory
{
    internal class ToyotaFactory : /*ISedanFactory,*/ ISuvFactory
    {
        public ISedan CreateSedan(string segment)
        {
            return segment switch
            {
                "Compact" => new ToyotaCompactSedan(),
                "Full" => new ToyotaFullSedan(),
                _ => throw new ArgumentException("Invalid segment", nameof(segment)),
            };
        }

        public ISuv CreateSuv(string segment)
        {
            return segment switch
            {
                "Compact" => new ToyotaCompactSuv(),
                "Full" => new ToyotaFullSuv(),
                _ => throw new ArgumentException("Invalid segment", nameof(segment)),
            };
        }
    }
}
