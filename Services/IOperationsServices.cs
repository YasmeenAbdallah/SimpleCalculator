using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
   public interface IOperationsServices
    {
        // Implement the add function 
         double Add(double num1, double num2);


        // Implement the subtract 
         double Subtract(double num1, double num2);



        // Implement the multiply function
         double Multiply(double num1, double num2);


        // Implement the divide function 
        double Divide(double num1, double num2);
       

    }
}
