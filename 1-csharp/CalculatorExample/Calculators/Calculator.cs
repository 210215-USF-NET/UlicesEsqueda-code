using System;

namespace Calculators
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return (value1 + value2);
        }

        public int Sub(int value1, int value2)
        {
            return (value1 - value2);
        }

        public int Mul(int value1, int value2)
        {
            return (value1 * value2);
        }

        public int Div(int value1, int value2)
        {
            return (value1 / value2);
        }

        public int Fib(int value)
        {
            if (value == 0) { return 0; }
            else if (value == 1) { return 1; }
            else {return (Fib(value - 1) + Fib(value - 2)); } 
        }

        public bool Prime(int value)
        {
            
            return true;
        }
    }
}
