using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateDiscount(decimal price)
        {
            return _discountStrategy.Calculate(price);
        }
    }

}
