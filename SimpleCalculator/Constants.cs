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
        string SetterPattern = @"^(?<Variable>[a-z])\s?[=]\s?(?<ConstantValue>-?\d+)$"; // Regex pattern for setting a constant
        public string Variable;  // Parsed elements of the expression
        public int ConstantValue;
        public static Dictionary<string, int> ConstantDictionary = new Dictionary<string, int>();
        public bool KeepGoing = true;

        //  Evaluates and parses when user is trying to set a constant
        public void SliceConstant(string UserInput)
        {
            // Instantiate Regex
            Regex SetterRegex = new Regex(SetterPattern);
            Match SetterMatch = SetterRegex.Match(UserInput);

            // Checks the input against the Setter Regex
            if (true == SetterRegex.IsMatch(UserInput))
            {
                Variable = (SetterMatch.Groups["Variable"].Value);  // Parses input into two variables
                ConstantValue = Convert.ToInt32(SetterMatch.Groups["ConstantValue"].Value);

                KeepGoing = false; // Keeps Program from further evaluation of UserInput

                if (ConstantDictionary.ContainsKey(Variable))  // Checks if variable is already in the dictionary
                {
                    Console.WriteLine("The variable '" + Variable + "' already has an assigned value."); // Prints error if so
                } else
                {
                    ConstantDictionary.Add(Variable, ConstantValue);  // Add to dictionary if it's unused
                    Console.WriteLine("You have set '" + Variable + "' to equal " + ConstantValue + ".");  // Prints verification
                }
            }
            else
            {
                KeepGoing = true;
            }
        }
    }
}
