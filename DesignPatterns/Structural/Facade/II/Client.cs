namespace DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        static IBasketService _basketService;
        static IProductsService _productsService;
        static IPaymentService _paymentService;

        public static void Execute()
        {
            int[] products = [2, 53, 112, 88];


            /*foreach (var productId in products)
            {
                var price = _productsService.GetPrice(productId);
                _basketService.AddProduct(productId, price);
            }
            var totalPrice = _basketService.GetTotalPrice();
            var basketId = _basketService.GetId();
            _paymentService.Pay(basketId, totalPrice);*/

            Shop shop = new Shop(_basketService, _productsService, _paymentService);
            shop.BuyProducts(products);
        }
    }
}
