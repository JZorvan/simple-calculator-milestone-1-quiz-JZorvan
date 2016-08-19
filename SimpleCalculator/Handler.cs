using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleCalculator
{
    public class Handler
    {
        // Handles Program Exit
        public bool Exit(string UserInput)
        {
            List<string> Exits = new List<string>() { "quit", "exit" };  // Recognized exit commands

            // If input is an exit command, writes message, delays, then exits
            if (Exits.Contains(UserInput))
            {
                Console.WriteLine("See you next time!");
                Thread.Sleep(1000);
                Environment.Exit(0);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
