using System.Collections.Generic;
using FizzBuzz.Core.Rules;

namespace FizzBuzz.Core
{
    public static class FizzBuzzFactory
    {
        private static IList<IFizzBuzzRule> GetDefaultRules()
        {
            return new List<IFizzBuzzRule> {new DivisibleBy3Rule(), new DivisibleBy5Rule(), new DefaultRule()};
        }

        public static FizzBuzzEngine GetFizzBuzzEngineWithDefaultRules()
        {
            return new FizzBuzzEngine(GetDefaultRules());
        }

        public static FizzBuzzEngine GetFizzBuzzEngineWithStandardAndPrimeRules()
        {
            var rules = GetDefaultRules();
            rules.Add(new PrimeNumberRule());
            return new FizzBuzzEngine(rules);
        }
    }
}
