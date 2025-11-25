namespace DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            Console.WriteLine(FlyweightFactory.Instance);

            var product11 = new Product()
            {
                Manufacturer = "Company A",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "Product A",
                Description = "Description of Product A",
                Weight = 1.5f,
                ProductionDate = new DateTime(2023, 1, 1),
                ExpirationDate = new DateTime(2024, 1, 1)
            };
            //product11.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product11.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product12 = new Product()
            {
                Manufacturer = "Company A",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "Product A",
                Description = "Description of Product A",
                Weight = 1.5f,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2024, 2, 1)
            };
            //product12.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product12.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product13 = new Product()
            {
                Manufacturer = "Company A",
                Logo = new byte[] { 0x20, 0x20, 0x20 },
                Name = "Product A",
                Description = "Description of Product A",
                Weight = 1.5f,
                ProductionDate = new DateTime(2023, 3, 1),
                ExpirationDate = new DateTime(2024, 3, 1)
            };
            //product13.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product13.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product21 = new Product()
            {
                Manufacturer = "Company B",
                Logo = new byte[] { 0x30, 0x30, 0x30 },
                Name = "Product B",
                Description = "Description of Product B",
                Weight = 2.0f,
                ProductionDate = new DateTime(2023, 1, 15),
                ExpirationDate = new DateTime(2024, 1, 15)
            };
            //product21.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product21.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product22 = new Product()
            {
                Manufacturer = "Company B",
                Logo = new byte[] { 0x30, 0x30, 0x30 },
                Name = "Product B",
                Description = "Description of Product B",
                Weight = 2.0f,
                ProductionDate = new DateTime(2023, 2, 15),
                ExpirationDate = new DateTime(2024, 2, 15)
            };
            //product22.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product22.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product23 = new Product()
            {
                Manufacturer = "Company B",
                Logo = new byte[] { 0x30, 0x30, 0x30 },
                Name = "Product B",
                Description = "Description of Product B",
                Weight = 2.0f,
                ProductionDate = new DateTime(2023, 3, 15),
                ExpirationDate = new DateTime(2024, 3, 15)
            };
            //product23.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(product23.ProductFlyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            product23.Description = "Updated Description of Product B";
            //var clone = (ProductFlyweight)product23.ProductFlyweight.Clone();
            //clone.Description = "Updated Description of Product B";
            //product23.ProductFlyweight = FlyweightFactory.Instance.GetFlyweight(clone);
            Console.WriteLine(FlyweightFactory.Instance);

            product11.ShowDetails();
            product12.ShowDetails();
            product13.ShowDetails();
            product21.ShowDetails();
            product22.ShowDetails();
            product23.ShowDetails();

            Console.ReadLine();
        }
    }
}
