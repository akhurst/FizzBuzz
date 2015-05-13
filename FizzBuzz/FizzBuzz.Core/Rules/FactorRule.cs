namespace FizzBuzz.Core.Rules
{
    public abstract class FactorRule : BaseRule
    {
        protected abstract int Factor { get; }
        protected abstract string Output { get; }

        protected override bool RuleApplicable(int input, string currentOutput)
        {
            return input%Factor == 0;
        }

        protected override string ExecuteRule(int input, string currentOutput)
        {
            return currentOutput+Output;
        }
    }
}
