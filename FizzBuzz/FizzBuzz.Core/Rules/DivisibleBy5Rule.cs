namespace FizzBuzz.Core.Rules
{
    public class DivisibleBy5Rule : FactorRule
    {
        protected override int Factor
        {
            get { return 5; }
        }

        protected override string Output
        {
            get { return "Buzz"; }
        }
    }
}
