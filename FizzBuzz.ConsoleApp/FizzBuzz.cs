namespace FizzBuzz.ConsoleApp
{
    /// <summary>
    /// FizzBuzz? implement this interface. Other than fizzbuzz requirement? implement this too.
    /// </summary>
    public interface INumberToText
    {
        /// <summary>
        /// Returns a string based on the input number, the implementation is up to you.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        string GetText(int i);
    }

    /// <summary>
    /// Provides the fizz buzz functionality as stated by the requirement
    /// </summary>
    public class FizzBuzz : INumberToText
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
