namespace FizzBuzz.Core.Rules
{
    public class DivisibleBy3Rule : FactorRule
    {
        protected override int Factor
        {
            get { return 3; }
        }

        protected override string Output
        {
            get { return "Fizz"; }
        }
    }
}
