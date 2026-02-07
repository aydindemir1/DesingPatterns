using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class DiscountStrategyResolver
    {
        public IDiscountStrategy Resolve(string userType)
        {
            return userType switch
            {
                "Student" => new StudentDiscountStrategy(),
                "Vip" => new VipDiscountStrategy(),
                _ => new NoDiscountStrategy()
            };
        }
    }

}
