using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : DiscountHandlerBase
    {
        public string Name { get; }
        private readonly float _maxDiscount;
        private readonly float _minPrice;

        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler? nextHandler = null) : base(nextHandler)
        {
            Name = name;
            _maxDiscount = maxDiscount;
            _minPrice = minPrice;
        }


        public override bool Discount(float value, float price)
        {
            if (value > _maxDiscount || price < _minPrice)
                return base.Discount(value, price);

            Console.WriteLine($"{Name} udzielił rabatu {value}");
            return true;
        }
    }
}
