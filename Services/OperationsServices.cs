using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public class OperationsServices : IOperationsServices
    {
        // Implement the add function 
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        // Implement the subtract 
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }


        // Implement the multiply function
        public double Multiply(double num1, double num2)
        {
            
            return (num1 * num2);
        }

        // Implement the divide function 
        public double Divide(double num1, double num2)
        {

            return (num1 / num2);
        }

    }
}
