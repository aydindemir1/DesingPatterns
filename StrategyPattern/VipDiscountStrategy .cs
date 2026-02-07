using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class VipDiscountStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal price)
        {
            return price * 0.20m;
        }
    }
}
