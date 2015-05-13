namespace FizzBuzz.Core.Rules
{
    public class DefaultRule : BaseRule
    {
        protected override bool RuleApplicable(int input, string currentOutput)
        {
            return string.IsNullOrEmpty(currentOutput);
        }

        protected override string ExecuteRule(int input, string currentOutput)
        {
            return input.ToString();
        }
    }
}
