namespace FizzBuzz.Core.Rules
{
    public interface IFizzBuzzRule
    {
        string GenerateOutput(int input, string currentOutput);
    }
}
