using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKataLib
{
    public class StringCalculator
    {

        public int Add(string numbers)
        {
            if(numbers == "")
                return 0;
            else
            {
                char[] delimeters = getDelimiters(numbers);
                numbers = getOnlyNumberList(numbers);
                string[] numbersArray = numbers.Split(delimeters);

                int sum = 0;
                string negativeNumbers = "";
                bool thereIsNegative = false;

                foreach (string str_umber in numbersArray)
                {
                    int number = Int32.Parse(str_umber);
                    if (number < 0)
                    {
                        thereIsNegative = true;
                        negativeNumbers += str_umber + " ";
                    }
                    else if(number < 1000)
                        sum += number;
                }
                if(thereIsNegative)
                    throw new ArgumentException("negatives not allowed "+ negativeNumbers);
                return sum;
            }
        }

        private char[] getDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                return new char[] { numbers[2] };
            }
            else 
                return new char[] { ',', '\n' };
        }

        string getOnlyNumberList(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                return numbers.Substring(4);
            }
            else
                return numbers;
        }
    }
}
