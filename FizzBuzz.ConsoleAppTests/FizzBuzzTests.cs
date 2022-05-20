using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.ConsoleApp.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [TestMethod()]
        public void PrintTest1_PrintNumber()
        {
            var input = 1;
            var actual = fizzBuzz.GetText(input);
            var expected = input.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintTest2_PrintFizz()
        {
            var input = 3;
            var actual = fizzBuzz.GetText(input);
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintTest3_PrintBuzz()
        {
            var input = 5;
            var actual = fizzBuzz.GetText(input);
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintTest4_PrintFizzBuzz()
        {
            var input = 15;
            var actual = fizzBuzz.GetText(input);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
    }
}