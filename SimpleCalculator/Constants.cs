using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Constants
    {
        // Variables
        string SetterPattern = @"^(?<Variable>[a-z])\s?[=]\s?(?<ConstantValue>-?\d+)"; // Regex pattern for setting a constant
        public string Variable;  // Parsed elements of the expression
        public int ConstantValue;
        public string Equals = "=";

        //Instantiate
        Stack Stack = new Stack();

        public void SliceConstant(string UserInput)
        {
            // Instantiate Regex
            Regex SetterRegex = new Regex(SetterPattern);
            Match SetterMatch = SetterRegex.Match(UserInput);

            // Checks the input against the Setter Regex
            if (true == SetterRegex.IsMatch(UserInput))
            {
                Variable = (SetterMatch.Groups["Variable"].Value);
                ConstantValue = Convert.ToInt32(SetterMatch.Groups["ConstantValue"].Value);
            }
        }

        public void SetConstant(string variable, int ConstantValue)
        {
            
        }
    }
}
