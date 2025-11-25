namespace DesignPatterns.Structural.Flyweight
{
    internal class Product
    {

        /*public string Manufacturer { get => ProductFlyweight.Manufacturer; set => ProductFlyweight.Manufacturer = value; }
        public byte[] Logo { get => ProductFlyweight.Logo; set => ProductFlyweight.Logo = value; }
        public string Name { get => ProductFlyweight.Name; set => ProductFlyweight.Name = value; }
        public string Description { get => ProductFlyweight.Description; set => ProductFlyweight.Description = value; }
        public float Weight { get => ProductFlyweight.Weight; set => ProductFlyweight.Weight = value; }*/
        public string Manufacturer { get => ProductFlyweight.Manufacturer; set => SetValue(x => x.Manufacturer = value); }
        public byte[] Logo { get => ProductFlyweight.Logo; set => SetValue(x => x.Logo = value); }
        public string Name { get => ProductFlyweight.Name; set => SetValue(x => x.Name = value); }
        public string Description { get => ProductFlyweight.Description; set => SetValue(x => x.Description = value); }
        public float Weight { get => ProductFlyweight.Weight; set => SetValue(x => x.Weight = value); }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ProductFlyweight ProductFlyweight { get; set; } = new ProductFlyweight();


        private void SetValue(Action<ProductFlyweight> action)
        {
            var clone = (ProductFlyweight)ProductFlyweight.Clone();
            action(clone);
            ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(clone);
        }


        public void ShowDetails()
        {
            //Console.WriteLine($"Product: {Name}, Manufacturer: {Manufacturer}, Weight: {Weight}kg, Production Date: {ProductionDate.ToShortDateString()}, Expiration Date: {ExpirationDate.ToShortDateString()}");
            ProductFlyweight.ShowDetails(this);
        }
    }
}
