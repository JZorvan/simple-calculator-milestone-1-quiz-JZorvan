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
        public void Exit(string UserInput)
        {
            List<string> Exits = new List<string>() { "quit", "exit" };  // Recognized exit commands

            // If input is an exit command, writes message, delays, then exits
            if (Exits.Contains(UserInput))
            {
                Console.WriteLine("See you next time!");  // Bye-bye message
                Thread.Sleep(1000);  // One second delay
                Environment.Exit(0);  // Exits program
            }
        }
    }
}
