using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator
    {
        public int Add(int First, int Second)
        {
            return First + Second;
        }
        public int Subtract(int First, int Second)
        {
            return First - Second;
        }
        public int Multiply(int First, int Second)
        {
            return First * Second;
        }
        public int Divide(int First, int Second)
        {
            return First / Second;
        }
        public int Modulus(int First, int Second)
        {
            return First % Second;
        }
    }
}
