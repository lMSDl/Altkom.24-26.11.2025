using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {

        static FlyweightFactory()
        {
        }
        public static FlyweightFactory Instance { get; } = new FlyweightFactory();

        private string GetKey(ProductFlyweight productFlyweight)
        {
            return $"{productFlyweight.Manufacturer}_{productFlyweight.Name}_{productFlyweight.Description}_{productFlyweight.Weight}";
        }
        Dictionary<string, ProductFlyweight> _flyweights = [];

        public ProductFlyweight GetFlyweight(ProductFlyweight productFlyweight)
        {
            var key = GetKey(productFlyweight);
            if (_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine("Używamy istniejącego obiektu.");
                return flyweight;
            }
            Console.WriteLine("Zapisujemy nowy obiekt w cache");
            _flyweights[key] = productFlyweight;
            return productFlyweight;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"FlyweightFactory count: {_flyweights.Count}");

            foreach (var flyweight in _flyweights)
            {
                stringBuilder.AppendLine(flyweight.Key);
            }
            return stringBuilder.ToString();
        }
    }
}
