using System;
using Xceed.Wpf.Toolkit;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers");

            double Number1 = Convert.ToDouble(Console.ReadLine());
            double Number2 = Convert.ToDouble(Console.ReadLine());
            var CalculatorClassObject = new Calculator.CalculatorClass();
            Double Result = CalculatorClassObject.Addition(Number1, Number2);
            Console.WriteLine(Result);
        }
    }
}
