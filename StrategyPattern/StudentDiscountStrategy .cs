using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal price)
        {
            return price * 0.10m;
        }
    }
}
