using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public class VipDiscountStrategy : IDiscountStrategy
    {
        public string UserType => "Vip";

        public decimal Calculate(decimal price)
            => price * 0.20m;
    }
}
