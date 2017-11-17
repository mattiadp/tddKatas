using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Exercise: http://osherove.com/tdd-kata-1/


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
        
                foreach (string str_number in numbersArray)
                {
                    if (!chekIfNegative(str_number, ref negativeNumbers))
                        sumStringNum(str_number, ref sum);
                }
                if(negativeNumbers!="")
                    throw new ArgumentException("negatives not allowed "+ negativeNumbers);
                return sum;
            }
        }

        private void sumStringNum(string numberStr, ref int sum)
        {
            int num = Int32.Parse(numberStr);
            if (num < 1000)
                sum += num;
        }

        private bool chekIfNegative(string numberStr, ref string negativeList)
        {
            if (numberStr[0] == '-')
            {
                negativeList += numberStr + " ";
                return true;
            }
            else
                return false;
        }

        private string[] getDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                Regex headerexpression = new Regex(@"(?<=//)(.*)(?=\n)");
                string delimeters = headerexpression.Match(numbers).Value;
                if (delimeters[0] == '[')
                {
                    Regex bracketexpression = new Regex(@"(?<=\[)(.*?)(?=\])");
                    MatchCollection matchesDelimiters = bracketexpression.Matches(delimeters);
                    string[] delimitersArray = new string[matchesDelimiters.Count];
                    int idx = 0;
                    foreach (Match delimiter in matchesDelimiters)
                    {
                        delimitersArray[idx] = delimiter.Groups[0].Value;
                        idx++;
                    };
                    return delimitersArray;
                }
                return new string[] { delimeters };
            }
            else 
                return new string[] { ",", "\n" };
        }

        private string getOnlyNumberList(string numbers)
        {
            Regex header = new Regex(@"(?<=\n)(.*)");
            return  header.Match(numbers).ToString();
        }
    }
}
