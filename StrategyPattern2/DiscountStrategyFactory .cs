using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern2
{
    public class DiscountStrategyFactory : IDiscountStrategyFactory
    {
        private readonly IEnumerable<IDiscountStrategy> _strategies;

        public DiscountStrategyFactory(IEnumerable<IDiscountStrategy> strategies)
        {
            _strategies = strategies;
        }

        public IDiscountStrategy Create(string userType)
        {
            var strategy = _strategies
                .FirstOrDefault(s => s.UserType == userType);

            return strategy ?? _strategies.First(s => s.UserType == "None");
        }
    }

}
