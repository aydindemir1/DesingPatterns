using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _strategy;

        public DiscountCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(decimal price)
        {
            return _strategy.Calculate(price);
        }
    }

}
