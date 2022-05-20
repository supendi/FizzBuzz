using System;

namespace FizzBuzz.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            var printer = new FizzBuzzPrinter(fizzBuzz);

            printer.Print(100);
        }
    }
}
