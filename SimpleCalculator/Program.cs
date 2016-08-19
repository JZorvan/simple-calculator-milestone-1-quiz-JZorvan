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
            String Prompt2 = "]>  ";
            int Counter = 0;
            bool GoForth = true;
            // Instantiate Classes
            Expression Expression = new Expression();
            Calculator Calculator = new Calculator();  // I'm not using this yet.
            Handler Handler = new Handler();

            // Print an introduction to the program
            Console.WriteLine("***  Welcome to Simple Calculator!  ***\r\nPlease enter an equation using two numbers.\r\nThis calculator can add, subtract, multiply, divide, and use the modulus.\r\nType 'lastq' to see the last input you entered.\r\nType 'last' to repeat the last answer.\r\nType 'exit' or 'quit' when you are done.\r\n_______________________________________\r\n");
            
            // Runs program in a loop
            while (GoForth == true)
            {
                Console.Write(Prompt1 + Counter + Prompt2);  // Prints prompt
                String UserInput = Console.ReadLine().ToLower();  // Collects input in lower case

                Handler.Exit(UserInput);  // Handles exit commands, if present
                Expression.Slicer(UserInput);  // Runs splicer code, which evaluates and parses an expression
                Expression.Calculate(Expression.Operator); // Runs calculate code, which determines and executes arithmatic
                Counter++;  // Increases prompt counter
            } 

            Console.Read();
        }
    }
}
