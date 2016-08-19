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

        public void LastQ(string UserInput)
        {
            if (UserInput == "lastq")  // If input is 'lastq', print last command to console and switches off evaluation and calculation
            {
                Console.WriteLine(LastInput);
                DoThis = false;
            }
            else  // Switches evaluation and calculation to 'on', in case it was turned off
            {
                DoThis = true;
            }

        }
    }
}
