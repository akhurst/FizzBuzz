using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Core;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class WhenPrintingARangeWithStandardAndPrimeRules
    {
        private FizzBuzzEngine fizzBuzz;

        [SetUp]
        public virtual void SetUp()
        {
            fizzBuzz = FizzBuzzFactory.GetFizzBuzzEngineWithStandardAndPrimeRules();
        }
        [Test]
        public void GivenInputIsDivisbleBy3ShouldDisplayFizzBang()
        {
            var output = fizzBuzz.GetOutput(3);
            output.Should().Be("Fizz!");
        }

        [Test]
        public void GivenInputIsDivisbleBy5ShouldDisplayBuzzBang()
        {
            var output = fizzBuzz.GetOutput(5);
            output.Should().Be("Buzz!");
        }

        [Test]
        public void GivenInputIsNeitherDivisbleBy3Or5OrPrimeShouldDisplayNumber()
        {
            var output = fizzBuzz.GetOutput(4);
            output.Should().Be("4");
        }

        [Test]
        public void GivenInputIsPrimeShouldDisplayAnExclamationPoint()
        {
            var output = fizzBuzz.GetOutput(13);
            output.Should().Be("13!");
        }

        [Test]
        public void GivenInputIsDivisbleBy3And5AndNotPrimeShouldDisplayFizzBuzz()
        {
            var output = fizzBuzz.GetOutput(15);
            output.Should().Be("FizzBuzz");
        }

        [Test]
        public void GivenInputIsDivisibleBy3AndNotPrimeShouldDisplayFizz()
        {
            var output = fizzBuzz.GetOutput(6);
            output.Should().Be("Fizz");
        }
    }
}
