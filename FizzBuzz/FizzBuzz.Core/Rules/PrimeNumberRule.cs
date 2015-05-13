namespace FizzBuzz.Core.Rules
{
    public class PrimeNumberRule : BaseRule
    {
        protected override bool RuleApplicable(int input, string currentOutput)
        {
            return IsPrime(input);
        }

        protected override string ExecuteRule(int input, string currentOutput)
        {
            return currentOutput + "!";
        }


        /// <summary>
        /// Pulled from http://www.dotnetperls.com/prime, they pulled it from System.Core assembly. I did not feel the need to test this extensively given its source.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        private static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

    }
}
