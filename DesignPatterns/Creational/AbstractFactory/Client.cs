
namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            var order = new Order();

            order.MakeOrder((ISuvFactory)new HondaFactory(), "Compact");
            Console.WriteLine("Ordered: " + order.CarName());

            order.MakeOrder((ISedanFactory)new HondaFactory(), "Full");
            Console.WriteLine("Ordered: " + order.CarName());

            order.MakeOrder((ISuvFactory)new ToyotaFactory(), "Compact");
            Console.WriteLine("Ordered: " + order.CarName());
        }

    }
}
