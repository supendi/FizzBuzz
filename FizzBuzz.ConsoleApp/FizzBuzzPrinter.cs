using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.ConsoleApp
{
    /// <summary>
    /// Lets say this one as a presenter layer
    /// who consumes the fizzbuzz class (service layer)
    /// </summary>
    public class FizzBuzzPrinter
    {
        FizzBuzz fizzBuzz;
        public FizzBuzzPrinter(FizzBuzz fizzBuzz)
        {
            this.fizzBuzz = fizzBuzz;
        }

        /// <summary>
        /// Prints the generated text by fizzbuzz n times into console
        /// </summary>
        public void Print(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input should be greater than 0");
            }

            for (int i = 1; i <= 100; i++)
            {
                var text = fizzBuzz.GetText(i);
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
