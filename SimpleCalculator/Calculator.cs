using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    // This class performs the math
    public class Calculator
    {
        public int Add(int First, int Second)  // Performs addition
        {
            return First + Second;
        }
        public int Subtract(int First, int Second)  // Performs suntraction
        {
            return First - Second;
        }
        public int Multiply(int First, int Second)  // Performs multiplication
        {
            return First * Second;
        }
        public int Divide(int First, int Second)  // Performs division
        {
            return First / Second;
        }
        public int Modulus(int First, int Second)  // Performs modulus function
        {
            return First % Second;
        }
    }
}
