using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.ConsoleApp
{
    public class FizzBuzz
    {
        /// <summary>
        /// Print fizz, buzz or fizzbuzz
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string GetText(int i)
        {
            var isFizzBuzz = i % 3 == 0 && i % 5 == 0;
            var isBuzz = i % 5 == 0;
            var isFizz = i % 3 == 0;

            var text = isFizzBuzz ? "FizzBuzz" : isBuzz ? "Buzz" : isFizz ? "Fizz" : i.ToString();
            return text;
        }
    }
}
