using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Core.Rules;

namespace FizzBuzz.Core
{
    public class FizzBuzzEngine
    {
        private readonly IEnumerable<IFizzBuzzRule> rules; 
        public FizzBuzzEngine(IEnumerable<IFizzBuzzRule> rules)
        {
            this.rules = rules;
        }
        public string GetOutput(int input)
        {
            return rules.Aggregate<IFizzBuzzRule, string>(null, (current, rule) => rule.GenerateOutput(input, current));
        }

        public string PrintRange(int start, int end)
        {
            var stringBuilder = new StringBuilder();
            for (var i = start; i <= end; i++)
            {
                stringBuilder.AppendLine(GetOutput(i));
            }
            return stringBuilder.ToString();
        }
    }
}
