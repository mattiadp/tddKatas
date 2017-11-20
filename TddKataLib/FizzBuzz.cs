using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKataLib
{
    public class FizzBuzz
    {
        public string apply(int input)
        {
            string output = "";
            if (input % 3 == 0 || findChar('3', input.ToString()))
                output += "Fizz";
            if (input % 5 == 0 || findChar('5', input.ToString()))
                output += "Buzz";
            if(output == "")
                output += input.ToString();
            return output;
        }

        bool findChar(char input, string word)
        {
            foreach(char letter in word.ToCharArray())
            {
                if (letter == input)
                    return true;
            }
            return false;
        }
    }
}
