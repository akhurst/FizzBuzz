using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core.Rules
{
    public abstract class BaseRule : IFizzBuzzRule
    {
        protected abstract bool RuleApplicable(int input, string currentOutput);
        protected abstract string ExecuteRule(int input, string currentOutput);

        public string GenerateOutput(int input, string currentOutput)
        {
            if (RuleApplicable(input, currentOutput))
            {
                return ExecuteRule(input, currentOutput);
            }
            else
            {
                return currentOutput;
            }
        }
    }
}
