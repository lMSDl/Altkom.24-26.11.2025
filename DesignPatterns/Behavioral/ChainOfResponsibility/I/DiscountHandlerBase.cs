namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandlerBase : IDiscountHandler
    {
        private readonly IDiscountHandler? _nextHandler;
        public DiscountHandlerBase(IDiscountHandler? nextHandler)
        {
            _nextHandler = nextHandler;
        }


        public virtual bool Discount(float value, float price)
        {
            return _nextHandler?.Discount(value, price) ?? false;
        }
    }
}
