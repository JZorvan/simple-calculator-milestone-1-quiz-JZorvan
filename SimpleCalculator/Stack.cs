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
        // Variables
        public string LastInput;  // Input is saved to this after use, in case of 'lastq' command
        public bool DoThis = true;  // Used to turn program progression on or off

        // Allows recall of a user's last command
        public void LastQ(string UserInput)
        {
            if (UserInput == "lastq")  // If input is 'lastq', print last command to console and switches off evaluation and calculation
            {
                DoThis = false;  // Turns off evaluation and calculation
                if (LastInput != "")
                {
                    Console.WriteLine("Your last command:  " + LastInput);  // Prints
                }
                else
                {
                    Console.WriteLine("You haven't entered any previous command.");      
                }

            }
            else  // Switches evaluation and calculation to 'on', in case it was turned off
            {
                DoThis = true;
            }
        }

        //  Handles recall of the answer that was printed to the console
        public void LastAnswer(string UserInput, int Answer)
        {
            if (UserInput == "last")  // If input is 'last', print last answer to console and switches off evaluation and calculation
            {
                DoThis = false;  // Turns off evaluation and calculation
                if (Answer != 0)
                {
                    Console.WriteLine("Your last answer was:  " + Answer);  // Prints
                }
                else
                {
                    Console.WriteLine("No equations have been entered yet");
                }

            }
            else  // Switches evaluation and calculation to 'on', in case it was turned off
            {
                DoThis = true;
            }
        }
    }
}
