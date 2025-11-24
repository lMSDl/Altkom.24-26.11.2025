namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private ICar? car;

        public string? CarName()
        {
            return car?.Name;
        }

        public void MakeOrder(ISuvFactory suvFactory, string segment)
        {
           car = suvFactory.CreateSuv(segment);
        }
        public void MakeOrder(ISedanFactory sedanFactory, string segment)
        {
            car = sedanFactory.CreateSedan(segment);
        }
    }
}
