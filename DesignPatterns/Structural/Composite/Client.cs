namespace DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public static void Execute()
        {
            var warehouse = new Warehouse();

            var shelf1 = new Shelf();
            var shelf2 = new Shelf();

            warehouse.Components.Add(shelf1);
            warehouse.Components.Add(shelf2);

            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var box4 = new Box();

            shelf1.Components.Add(box1);
            shelf2.Components.Add(box2);
            shelf2.Components.Add(box3);

            warehouse.Components.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Components.Add(new Soda(Random.Shared.Next(5, 15)));
                box2.Components.Add(new Tea(Random.Shared.Next(20, 45)));
                box3.Components.Add(new Toy(Random.Shared.Next(50, 150)));
            }
            for (int i = 0; i < 5; i++)
            {
                box4.Components.Add(new Toy(Random.Shared.Next(20, 45)));
                box4.Components.Add(new Tea(Random.Shared.Next(50, 100)));
            }

            shelf1.Components.Add(new Toy(Random.Shared.Next(5, 15)));

            Console.WriteLine("Total value of warehouse: {0}", warehouse.GetValue());
            Console.WriteLine("----");
            Console.WriteLine("Total value of shelf1: {0}", shelf1.GetValue());

            Console.WriteLine("Total value of ???: {0}", warehouse.Components[2].GetValue());
        }
    }
}
