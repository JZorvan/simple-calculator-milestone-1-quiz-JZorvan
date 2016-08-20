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
            Handler Handler = new Handler();
            Stack Stack = new Stack();
            Constants Constants = new Constants();

            // Print an introduction to the program
            Console.WriteLine("***  Welcome to Simple Calculator!  ***\r\nPlease enter an equation using two numbers.\r\nThis calculator can add, subtract, multiply, divide, and use the modulus.\r\nType 'lastq' to see the last input you entered.\r\nType 'last' to repeat the last answer.\r\nType 'exit' or 'quit' when you are done.\r\n_______________________________________\r\n");
            
            // Runs program in a loop
            while (GoForth == true)
            {
                Console.Write(Prompt1 + Counter + Prompt2);  // Prints prompt
                String UserInput = Console.ReadLine().ToLower();  // Collects input in lower case

                Handler.Exit(UserInput);  // Handles exit commands, if present

                Stack.LastQ(UserInput);  // Prints last input, if user types 'lastq'
                
                if (Stack.DoThis == true)
                {
                    Stack.LastAnswer(UserInput, Expression.Answer);  // Print last answer, if user types 'last'
                }
                if (Stack.DoThis == true)
                {
                    Constants.SliceConstant(UserInput);  // Checks to see if user is trying to set a constant
                }
                if ((Constants.KeepGoing == true) && (Stack.DoThis == true))
                {
                    Expression.Slicer(UserInput);  // Runs splicer code, which evaluates and parses an expression
                    Expression.Calculate(Expression.Operator, UserInput); // Runs calculate code, which determines and executes arithmatic
                }
                   
                Counter++;  // Increases prompt counter
                Stack.LastInput = UserInput;  // Save the user input into a new variable before repeating so it can be recalled
            } 

            Console.Read();
        }
    }
}
