using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        // Variables
        string pattern = @"^(?<Num1>-?\d+)\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>-?\d+)"; // Regex pattern for expressions
        public int First;  // Parsed elements of the expression
        public int Second;
        public string Operator = "";  
        public int Answer;  // Holds the answer once math is complete

        // Instantiate
        Calculator Calculator = new Calculator();
        Stack Stack = new Stack();

        // Handles the evaluation and parses the expression
        public void Slicer(string UserInput)
        {
            // Instantiate Regex
            Regex Regex = new Regex(pattern);
            Match Match = Regex.Match(UserInput);

            // Checks the input against the Regular Expression
            if (true == Regex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(Match.Groups["Num1"].Value);
                Second = Convert.ToInt32(Match.Groups["Num2"].Value);
                Operator = Match.Groups["Oper"].Value;
                
            }
            else if (false == Regex.IsMatch(UserInput)) // If it isn't an acceptable expression..
            {
                Console.WriteLine("Your input is invalid, try again.");  //..delivers error message to user
                Operator = null;
            }
        }

        // Evaluates the operator, calls the right math method, prints answer, and passes answer to it's recall method
        public void Calculate(string Operator, string UserInput)
        {
            if (Operator == "+")  // Addition
            {
                Answer = Calculator.Add(First, Second);
                Console.WriteLine("Answer:  " + Answer);
                Stack.LastAnswer(UserInput, Answer);
            }
            else if (Operator == "-")  // Subtraction
            {
                Answer = Calculator.Subtract(First, Second);
                Console.WriteLine("Answer:  " + Answer);
                Stack.LastAnswer(UserInput, Answer);
            }
            else if (Operator == "*")  // Multiplication
            {
                Answer = Calculator.Multiply(First, Second);
                Console.WriteLine("Answer:  " + Answer);
                Stack.LastAnswer(UserInput, Answer);
            }
            else if (Operator == "/")  // Division
            {
                if (Second == 0)  // Throws error message if trying to divide by zero
                {
                    Console.WriteLine("You can't divide by zero, Holmes.");
                }
                else
                {
                    Answer = Calculator.Divide(First, Second);
                    Console.WriteLine("Answer:  " + Answer);
                    Stack.LastAnswer(UserInput, Answer);
                }
            }
            else if (Operator == "%")  // Modulus Function
            {
                Answer = Calculator.Modulus(First, Second);
                Console.WriteLine("Answer:  " + Answer);
                Stack.LastAnswer(UserInput, Answer);
            }
        }
    }
}
