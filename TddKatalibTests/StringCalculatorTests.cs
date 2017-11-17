using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TddKataLib;

namespace TddKatalibTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_Empty_String()
        {
            string numbers = "";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(0, result, 0.0, "Add Function not return 0 with empty string");
        }

        [TestMethod]
        public void Add_One_Number()
        {
            string numbers = "1";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(1, result, 0.0, "Add Function not return sum with one number");

        }

        [TestMethod]
        public void Add_Two_Number()
        {
            string numbers = "1,2";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(3, result, 0.0, "Add Function not return sum with two numbers");
        }

        [TestMethod]
        public void Add_Numbers()
        {
            string numbers = "1,2,3,5,7";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(18, result, 0.0, "Add Function not return sum with two numbers");
        }

        [TestMethod]
        public void Add_Numbers_newLine_between_numbers()
        {
            string numbers = "1\n2,3";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(6, result, 0.0, "Add Function not return sum with two numbers");
        }

        [TestMethod]
        public void Add_Numbers_with_custom_delimeter()
        {
            string numbers = "//;\n1;2";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(3, result, 0.0, "Add Function not return sum with two numbers");
        }

        [TestMethod]
        public void Add_Negative_numbers_throw_exeption()
        {
            try
            {
                string numbers = "//;\n-1;2;-5";
                StringCalculator calculator = new StringCalculator();
                int result = calculator.Add(numbers);
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("negatives not allowed -1 -5 ", ex.Message);
            }
        }

        [TestMethod]
        public void Add_Numbers_Higher_Than_Thousand()
        {
            string numbers = "//;\n1;2;1050";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(3, result, 0.0, "Add Function not return sum with two numbers");
        }


        [TestMethod]
        public void Add_Numbers_multycharater_between_nunmbers()
        {
            string numbers = "//;;\n1;;2;;1005";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(3, result, 0.0, "Add Function not return sum with two numbers");
        }


        [TestMethod]
        public void Add_Numbers_with_multyDelimiters()
        {
            string numbers = "//[;;][,]\n1;;2,1005";
            StringCalculator calculator = new StringCalculator();
            int result = calculator.Add(numbers);
            Assert.AreEqual(3, result, 0.0, "Add Function not return sum with two numbers");
        }

    }
}
