using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            // Prompt Variables
            String Prompt1 = "[";
            String Prompt2 = "]>";
            int Counter = 0;
            bool GoForth = true;
            List<string> Exits = new List<string>() { "quit", "exit" };  // Recognized exit commands

            Expression myexp = new Expression();
            Calculator myCalc = new Calculator();

            // Prints first prompt to Console
            while (GoForth == true)
            {
                Console.Write(Prompt1 + Counter + Prompt2);
                String UserInput = Console.ReadLine().ToLower();

                // Checks if input is an exit command, exits if so
                if (Exits.Contains(UserInput))
                {
                    GoForth = false;
                    Environment.Exit(0);
                }
                Counter++;  // Increased prompt counter
                myexp.Slicer(UserInput);  // Runs splicer code


                
            }
            
     
            Console.Read();
        }
    }
}
