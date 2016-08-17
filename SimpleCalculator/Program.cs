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

            Expression myexp = new Expression();

            // Prints first prompt to Console
            Console.Write(Prompt1 + Counter + Prompt2);
            String UserInput = Console.ReadLine().ToLower();
            Counter++; 
            Console.WriteLine(UserInput);
            myexp.Slicer(UserInput);
            

            Console.Write(Prompt1 + Counter + Prompt2);
            Console.Read();
        }
    }
}
