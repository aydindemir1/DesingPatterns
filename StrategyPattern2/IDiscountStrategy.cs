using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public interface IDiscountStrategy
    {
        decimal Calculate(decimal price);
        string UserType { get; }
    }

}
