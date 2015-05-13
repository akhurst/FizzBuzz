using FizzBuzz.Core;
using NUnit.Framework;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class WhenPrintingARangeWithStandardRules
    {
        [Test]
        public void GivenRangeIs1To15ShouldGetTheCorrectOutput()
        {
            var fizzBuzz = FizzBuzzFactory.GetFizzBuzzEngineWithDefaultRules();
            var output = fizzBuzz.PrintRange(1, 15);
            var expectedOutput = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
";
            output.Should().Be(expectedOutput);
        }
    }
}
