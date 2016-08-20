using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Stack
    {
        public string LastInput;
        public bool DoThis = true;
  
        // Expression Expression = new Expression();

        public void LastQ(string UserInput)
        {
            if (UserInput == "lastq")  // If input is 'lastq', print last command to console and switches off evaluation and calculation
            {
                Console.WriteLine("Your last command:  " + LastInput);
                DoThis = false;
            }
            else  // Switches evaluation and calculation to 'on', in case it was turned off
            {
                DoThis = true;
            }

        }
        public void LastAnswer(string UserInput, int Answer)
        {
            if (UserInput == "last")  // If input is 'last', print last answer to console and switches off evaluation and calculation
            {
                Console.WriteLine("Your last answer was:  " + Answer);
                DoThis = false;
            }
            else  // Switches evaluation and calculation to 'on', in case it was turned off
            {
                DoThis = true;
            }

        }
    }
}
