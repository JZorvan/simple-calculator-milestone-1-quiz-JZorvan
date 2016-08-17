using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        // Variables
        public bool GoForth = true;  // bool used for contuing program
        List<string> Exits = new List<string>() { "quit", "exit" };  // Recognized exit commands
        public string First = "", Second = "", Operator = "";  // Parsed elements of the expression
        List<char> Operators = new List<char>() { '+', '-', '*', '/', '%' };  // List of accepted operators

        public void Slicer(string UserInput)
        {
            // Checks if input is an exit command, exits if so
            if (Exits.Contains(UserInput))
            {
                GoForth = false;
                Environment.Exit(0);
            }
        
            // Checks for a leading hyphen, saves to First variable, deletes from input
            if (UserInput.StartsWith("-"))
            {
                First = First + "-";
                UserInput = UserInput.Substring(1);  // Why the hell isn't this working??

            }


            
        }
        
    }
}
