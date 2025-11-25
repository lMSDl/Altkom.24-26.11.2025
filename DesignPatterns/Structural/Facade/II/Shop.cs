using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.II
{
    internal class Shop
    {
        IBasketService _basketService;
        IProductsService _productsService;
        IPaymentService _paymentService;

        public Shop(IBasketService basketService, IProductsService productsService, IPaymentService paymentService)
        {
            _basketService = basketService;
            _productsService = productsService;
            _paymentService = paymentService;
        }

        public void BuyProducts(int[] products) {
            foreach (var productId in products)
            {
                var price = _productsService.GetPrice(productId);
                _basketService.AddProduct(productId, price);
            }
            var totalPrice = _basketService.GetTotalPrice();
            var basketId = _basketService.GetId();
            _paymentService.Pay(basketId, totalPrice);
        }
    }
}
