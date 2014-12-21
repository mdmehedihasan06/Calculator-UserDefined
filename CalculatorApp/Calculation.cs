using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculation
    {
        public double firstNumber;
        public double secondNumber;
        public double result;

        public double Add()
        {
            return result = firstNumber + secondNumber;
        }

        public double Subtract()
        {
            return result = firstNumber-secondNumber;
        }

        public double Multiply()
        {
            return result = firstNumber*secondNumber;
        }

        public double Divide()
        {
            return result = firstNumber/secondNumber;
        }
    }
}
