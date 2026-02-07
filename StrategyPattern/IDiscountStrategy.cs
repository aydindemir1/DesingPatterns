using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IDiscountStrategy
    {
        decimal Calculate(decimal price);
    }

}
