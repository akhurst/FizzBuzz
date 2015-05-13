using System;
using FizzBuzz.Core;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = FizzBuzzFactory.GetFizzBuzzEngineWithDefaultRules();
            Console.Out.Write(fizzBuzz.PrintRange(1,100));
        }
    }
}
