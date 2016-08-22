using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        // Variables
        string ExpPattern = @"^(?<Num1>-?\d+)\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>-?\d+)$"; // Regex pattern for expressions
        string LVarPattern = @"^(?<Num1>[a-z]{1})\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>-?\d+)$"; // Regex pattern for a variable on the left
        string RVarPattern = @"^(?<Num1>-?\d+)\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>[a-z]{1})$"; // Regex pattern for a variable on the right
        string DblVarPattern = @"^(?<Num1>[a-z]{1})\s?(?<Oper>[\+\-\*\/%])\s?(?<Num2>[a-z]{1})$"; // Regex pattern for two variables
        public int First;  // Parsed elements of the expression
        public int Second;
        public string SFirst;  // Temp elements to deal with strings when using variables
        public string SSecond;
        public string Operator = "";  
        public int Answer;  // Holds the answer once math is complete
        public bool DoMath = true;

        // Instantiate
        Calculator Calculator = new Calculator();
        Stack Stack = new Stack();
        Constants Constants = new Constants();

        // Handles the evaluation and parses the expression
        public void Slicer(string UserInput)
        {
            // Instantiate Regex
            Regex ExpRegex = new Regex(ExpPattern);
            Regex LVarRegex = new Regex(LVarPattern);
            Regex RVarRegex = new Regex(RVarPattern);
            Regex DblVarRegex = new Regex(DblVarPattern);
            Match ExpMatch = ExpRegex.Match(UserInput);
            Match LVarMatch = LVarRegex.Match(UserInput);
            Match RVarMatch = RVarRegex.Match(UserInput);
            Match DblVarMatch = DblVarRegex.Match(UserInput);

            // Checks the input against the Regular Expression
            if (true == ExpRegex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(ExpMatch.Groups["Num1"].Value);
                Second = Convert.ToInt32(ExpMatch.Groups["Num2"].Value);
                Operator = ExpMatch.Groups["Oper"].Value;
               
            }
            else if (true == LVarRegex.IsMatch(UserInput))
            {
                SFirst = LVarMatch.Groups["Num1"].Value;
                Second = Convert.ToInt32(LVarMatch.Groups["Num2"].Value);
                Operator = LVarMatch.Groups["Oper"].Value;
                if (Constants.ConstantDictionary.ContainsKey(SFirst))
                {
                    First = Constants.ConstantDictionary[SFirst];
                }
                else
                {
                    Console.WriteLine("I'm sorry, '" + SFirst + "' hasn't been assigned a value yet.");
                    DoMath = false;
                }
            }
            else if (true == RVarRegex.IsMatch(UserInput))
            {
                First = Convert.ToInt32(RVarMatch.Groups["Num1"].Value);
                SSecond = RVarMatch.Groups["Num2"].Value;
                Operator = RVarMatch.Groups["Oper"].Value;
                if (Constants.ConstantDictionary.ContainsKey(SSecond))
                {
                    Second = Constants.ConstantDictionary[SSecond];
                }
                else
                {
                    Console.WriteLine("I'm sorry, '" + SSecond + "' hasn't been assigned a value yet.");
                    DoMath = false;
                }

            }
            else if (true == DblVarRegex.IsMatch(UserInput))
            {
                SFirst = DblVarMatch.Groups["Num1"].Value;
                SSecond = DblVarMatch.Groups["Num2"].Value;
                Operator = DblVarMatch.Groups["Oper"].Value;
                if ((Constants.ConstantDictionary.ContainsKey(SFirst)) && (Constants.ConstantDictionary.ContainsKey(SSecond)))
                {
                    First = Constants.ConstantDictionary[SFirst];
                    Second = Constants.ConstantDictionary[SSecond];
                }
                else if ((Constants.ConstantDictionary.ContainsKey(SFirst) == false) && (Constants.ConstantDictionary.ContainsKey(SSecond) == false))
                {
                    Console.WriteLine("Neither of those variables have been set.");
                    DoMath = false;
                }
                else if ((Constants.ConstantDictionary.ContainsKey(SFirst)) && (Constants.ConstantDictionary.ContainsKey(SSecond) == false))
                {
                    Console.WriteLine("I'm sorry, '" + SSecond + "' hasn't been assigned a value yet.");
                    DoMath = false;
                }
                else if ((Constants.ConstantDictionary.ContainsKey(SFirst) == false) && (Constants.ConstantDictionary.ContainsKey(SSecond)))
                {
                    Console.WriteLine("I'm sorry, '" + SFirst + "' hasn't been assigned a value yet.");
                    DoMath = false;
                }
            }
            else  // If it isn't an acceptable expression..
            {
                Console.WriteLine("Your input is invalid, try again.");  //..delivers error message to user
                DoMath = false;
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
