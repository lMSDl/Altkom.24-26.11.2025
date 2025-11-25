namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class Client
    {
        public static void Execute()
        {
            IDiscountHandler handler1 = new DiscountHandler("Kierownik sklepu", 1000, 7500);
            IDiscountHandler handler2 = new DiscountHandler("Kierownik sali", 500, 7500, handler1);
            IDiscountHandler handler3 = new DiscountHandler("Kierownik kas", 250, 10000, handler2);
            IDiscountHandler handler4 = new DiscountHandler("Kasjer", 100, 10000, handler3);

            var result = handler4.Discount(500, 15000);
            if (!result)
                Console.WriteLine("Nie udzielono rabatu");

            result = handler2.Discount(2000, 8000);
            if (!result)
                Console.WriteLine("Nie udzielono rabatu");
        }
    }
}
