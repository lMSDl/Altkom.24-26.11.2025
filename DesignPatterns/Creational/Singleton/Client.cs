namespace DesignPatterns.Creational.Singleton
{
    internal class Client
    {
        public static void Execute()
        {
            Task.Run(() =>
            {
                var service1 = Context.Instance;
                Console.WriteLine(service1.GetSettings("1"));
            });

            Task.Run(() =>
            {
                var service2 = Context.Instance;
                Console.WriteLine(service2.GetSettings("2"));
                service2.SetSettings("3", "x");
            });

            Task.Run(() =>
            {
                var service3 = Context.Instance;
                Console.WriteLine(service3.GetSettings("3"));
            });

            Console.ReadLine();
        }

    }
}
