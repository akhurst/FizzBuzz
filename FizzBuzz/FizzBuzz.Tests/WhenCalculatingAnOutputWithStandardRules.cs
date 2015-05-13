using NUnit.Framework;
using FluentAssertions;
using FizzBuzz.Core;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class WhenCalculatingAnOutputWithStandardRules
    {
        private FizzBuzzEngine fizzBuzz;

        [SetUp]
        public virtual void SetUp()
        {
            fizzBuzz=FizzBuzzFactory.GetFizzBuzzEngineWithDefaultRules();
        }
        [Test]
        public void GivenInputIs3ShouldDisplayFizz()
        {
            var output =fizzBuzz.GetOutput(3);
            output.Should().Be("Fizz");
        }

        [Test]
        public void GivenInputIs5ShouldDisplayBuzz()
        {
            var output = fizzBuzz.GetOutput(5);
            output.Should().Be("Buzz");
        }

        [Test]
        public void GivenInputIsNeither3Or5ShouldDisplayNumber()
        {
            var output = fizzBuzz.GetOutput(2);
            output.Should().Be("2");
        }

        [Test]
        public void GivenInputIs3And5ShouldDisplayFizzBuzz()
        {
            var output = fizzBuzz.GetOutput(15);
            output.Should().Be("FizzBuzz");
        }
    }
}
