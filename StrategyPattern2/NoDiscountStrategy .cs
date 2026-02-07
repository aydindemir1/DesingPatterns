using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public string UserType => "None";

        public decimal Calculate(decimal price)
            => 0;
    }
}
