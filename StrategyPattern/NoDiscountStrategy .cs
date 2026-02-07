using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal price)
            => 0;
    }
}
