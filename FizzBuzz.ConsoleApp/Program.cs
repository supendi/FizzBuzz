using System;

namespace FizzBuzz.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var text = FizzBuzz.GetText(i);
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
