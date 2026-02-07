using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public string UserType => "Student";

        public decimal Calculate(decimal price)
            => price * 0.10m;
    }
}
