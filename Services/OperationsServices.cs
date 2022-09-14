using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public class OperationsServices : IOperationsServices
    {
        /// <summary>
        /// the adding function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        /// <summary>
        /// the Subtraction function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns> 
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }


        /// <summary>
        /// the Multiplying function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
        public double Multiply(double num1, double num2)
        {
            
            return (num1 * num2);
        }

        /// <summary>
        /// the Dividion function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns> 
        public double Divide(double num1, double num2)
        {

            return (num1 / num2);
        }

    }
}
