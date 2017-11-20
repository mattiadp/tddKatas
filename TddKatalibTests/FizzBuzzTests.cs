using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TddKataLib;

namespace TddKatalibTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Fizz_Buzz_Use_three()
        {
            int input = 3;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("Fizz", result, "Add Function not return 0 with empty string");
        }

        [TestMethod]
        public void Fizz_Buzz_Use_five()
        {
            int input = 5;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("Buzz", result, "Add Function not return 0 with empty string");
        }

        [TestMethod]
        public void Fizz_Buzz_Use_three_and_five()
        {
            int input = 15;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("FizzBuzz", result, "Add Function not return 0 with empty string");
        }


        [TestMethod]
        public void Fizz_Buzz_Use_four()
        {
            int input = 4;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("4", result, "Add Function not return 0 with empty string");
        }


        [TestMethod]
        public void Fizz_Buzz_There_is_three()
        {
            int input = 31;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("Fizz", result, "Add Function not return 0 with empty string");
        }

        [TestMethod]
        public void Fizz_Buzz_There_is_five()
        {
            int input = 52;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("Buzz", result, "Add Function not return 0 with empty string");
        }

        [TestMethod]
        public void Fizz_Buzz_There_is_five_mod_three()
        {
            int input = 51;
            FizzBuzz fizzbuzzer = new FizzBuzz();
            string result = fizzbuzzer.apply(input);
            Assert.AreEqual("FizzBuzz", result, "Add Function not return 0 with empty string");
        }

    }
}
