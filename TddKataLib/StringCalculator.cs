using System;
using System.Text.RegularExpressions;
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
                string[] delimeters = getDelimiters(numbers);
                numbers = getOnlyNumberList(numbers);
                string[] numbersArray = numbers.Split(delimeters, StringSplitOptions.None);

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

        private string[] getDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                Regex headerexpression = new Regex("(?<=//)(.*)(?=\n)");
                string delimeters = headerexpression.Match(numbers).Value;
                return new string[] { delimeters };
            }
            else 
                return new string[] { ",", "\n" };
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
