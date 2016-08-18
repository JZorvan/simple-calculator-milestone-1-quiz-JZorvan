using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        // Variables
       
        string pattern = @"^(?<Num1>-?\d+)\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>-?\d+)"; // Regex pattern for expressions
        public int First;
        public int Second;
        public string Operator = "";  // Parsed elements of the expressions

        public void Slicer(string UserInput)
        {
            // Instantiate Regex
            Regex Regex = new Regex(pattern);
            Match Matches = Regex.Match(UserInput);

            // Checks the input against the Regular Expression
            if (true == Regex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(Matches.Groups["Num1"].Value);
                Second = Convert.ToInt32(Matches.Groups["Num2"].Value);
                Operator = Matches.Groups["Oper"].Value;
            }
            else  // If it isn't an acceptable expression..
            {
                Console.WriteLine("Your input is invalid, try again.");  //..delivers error message to user
            }
        }
    }
}
