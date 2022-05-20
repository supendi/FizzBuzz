﻿namespace FizzBuzz.ConsoleApp
{
    /// <summary>
    /// Provides the fizz buzz functionality as stated by the requirement
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Gets fizz, buzz or fizzbuzz, based on the input argument
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public string GetText(int i)
        {
            var isFizzBuzz = i % 3 == 0 && i % 5 == 0;
            var isBuzz = i % 5 == 0;
            var isFizz = i % 3 == 0;

            var text = isFizzBuzz ? "FizzBuzz" : isBuzz ? "Buzz" : isFizz ? "Fizz" : i.ToString();
            return text;
        }
    }
}
