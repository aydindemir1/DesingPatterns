using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public interface IDiscountStrategyFactory
    {
        IDiscountStrategy Create(string userType);
    }

}
