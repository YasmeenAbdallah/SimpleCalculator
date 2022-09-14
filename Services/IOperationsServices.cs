using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
   public interface IOperationsServices
    {
        /// <summary>
        /// the adding function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
         double Add(double num1, double num2);


        /// <summary>
        /// the Subtraction function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
        double Subtract(double num1, double num2);



        /// <summary>
        /// the Multiplying function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
        double Multiply(double num1, double num2);

        /// <summary>
        /// the Dividion function
        /// </summary>
        /// <param name="num1"> the first number </param>
        /// <param name="num2">the second number</param>
        /// <returns></returns>
        double Divide(double num1, double num2);
       

    }
}
