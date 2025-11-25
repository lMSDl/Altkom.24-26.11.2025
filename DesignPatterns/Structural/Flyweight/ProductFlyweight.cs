namespace DesignPatterns.Structural.Flyweight
{
    internal class ProductFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public byte[] Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowDetails(Product product)
        {
            Console.WriteLine($"Product: {Name}, Description: {Description}, Manufacturer: {Manufacturer}, Weight: {Weight}kg, Production Date: {product.ProductionDate.ToShortDateString()}, Expiration Date: {product.ExpirationDate.ToShortDateString()}");
        }
    }
}
