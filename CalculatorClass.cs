using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  
    public class CalculatorClass
    {
        public Double Addition(Double Number1, double Number2)
        {
            return (Number1 + Number2);
        }

        public double Subtraction(double Number1, double Number2)
        {
            return (Number1 - Number2);
        }

        public double Multiplication(double Number1, double Number2)
        {
            return (Number1 * Number2);
        }

        public double Division(double Number1, double Number2)
        {
            return (Number1 / Number2);
        }
    }
}
