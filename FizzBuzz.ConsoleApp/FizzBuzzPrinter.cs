using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.ConsoleApp
{
    /// <summary>
    /// Lets say this one as the presentation layer
    /// who consumes the fizzbuzz class (service layer)
    /// </summary>
    public class FizzBuzzPrinter
    {
        INumberToText fizzBuzz;
        public FizzBuzzPrinter(INumberToText fizzBuzz)
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

            for (int i = 1; i <= n; i++)
            {
                var text = fizzBuzz.GetText(i);
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
