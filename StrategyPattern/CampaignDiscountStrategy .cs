using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class CampaignDiscountStrategy : IDiscountStrategy
    {
        public decimal Calculate(decimal price)
        {
            return price * 0.15m;
        }
    }
}
