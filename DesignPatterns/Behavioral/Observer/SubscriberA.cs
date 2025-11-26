namespace DesignPatterns.Behavioral.Observer
{
    internal class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value > 30)
            {
                Console.WriteLine("Subskrybent A rozpoczął obserwację");

                Thread.Sleep(Random.Shared.Next(1000, 5000)); // Symulacja przetwarzania

                Console.WriteLine($"SubscriberA zareagował na {value}");
            }
        }
    }
}