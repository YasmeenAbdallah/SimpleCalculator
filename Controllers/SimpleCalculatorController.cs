using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Models;
using SimpleCalculator.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace SimpleCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SimpleCalculatorController : ControllerBase
    {
        private readonly IOperationsServices _OperationServices = new OperationsServices();

        [HttpPost]
        public IList<CalculationResultsModel> Post([FromBody] NumbersModel nums)
        {

            IList<CalculationResultsModel> Results = new List<CalculationResultsModel>();
            CalculationResultsModel obj = new CalculationResultsModel();
            double num1 = 0;
            double num2 = 0;
            if (!double.TryParse(nums.Num1.ToString(), out num1) || !double.TryParse(nums.Num2.ToString(), out num2) || 
                nums.Num1 == null || nums.Num2 == null || num1 > 100000000000 || num1 < -100000000000 ||
               num2 > 100000000000 || num2 < -100000000000) {
              
                    obj.Summation = "please enter a vaild value  -Don't enter empty values , out of range(-100 billion , 100 billion ) . not number ";
                    obj.Subtraction = "please enter a vaild value  -Don't enter empty values , out of range(-100 billion , 100 billion ) . not number ";
                    obj.Multiplication = "please enter a vaild value  -Don't enter empty values , out of range(-100 billion , 100 billion ) . not number ";
                    obj.Divivsion = "please enter a vaild value  -Don't enter empty values , out of range(-100 billion , 100 billion ) . not number ";
                    Results.Add(obj);
                    return Results;

                }
            else
            {
                obj.Summation = (_OperationServices.Add(num1, num2)).ToString(); ;
                obj.Subtraction = (_OperationServices.Subtract(num1, num2)).ToString();
                obj.Multiplication = (_OperationServices.Multiply(num1, num2)).ToString();

                if (num2 == 0)
                {
                    obj.Divivsion = "Cannot divide by zero ";
                }
                else
                {
                    obj.Divivsion = (_OperationServices.Divide(num1, num2)).ToString();
                }

                Results.Add(obj);
                return Results;

            }





        }



         }
  }
   

