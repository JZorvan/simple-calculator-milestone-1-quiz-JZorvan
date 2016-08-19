using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Addition(int First, int Second)
        {
            return First + Second;
        }
        public int Subtraction(int First, int Second)
        {
            return First - Second;
        }
        public int Multiplication(int First, int Second)
        {
            return First * Second;
        }
        public int Division(int First, int Second)
        {
            if (Second == 0)
            {
                Console.WriteLine("You can't divide by zero, Holmes.");
                return 0;
            }
            else
            {
                return First / Second;
            }
        }
        public int Modulus(int First, int Second)
        {
            return First % Second;
        }
    }
}
