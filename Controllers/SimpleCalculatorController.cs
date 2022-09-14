using Microsoft.AspNetCore.Http;
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
        private readonly IOperationsServices _OperationServices;
        public SimpleCalculatorController()
        {
            _OperationServices = new OperationsServices();
        }
        /// <summary>
        /// function to get that take 2 numbers and return the 4 main operation +,-,*,/
        /// </summary>
        /// <param name="nums">the two numbers</param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCalResult")]
       
        public IActionResult GetCalResult([FromBody] NumbersModel nums)
        {
            try
            {
                CalculationResultsModel obj = new CalculationResultsModel();
                double num1 = 0;
                double num2 = 0;
                if (!double.TryParse(nums.Num1.ToString(), out num1)|| !double.TryParse(nums.Num2.ToString(), out num2))
                {
                    return BadRequest("please enter a valid  numbers  ");
                }
              
                if (num1 > 100000000000 || num1 < -100000000000 || num2 > 100000000000 || num2 < -100000000000)
                {
                    return BadRequest("please enter the  numbers in range (-100 billion , 100 billion )  ");
                }
                
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

                return Ok(obj);
            }

            catch (Exception)
            {

                throw;
            }
        }
    }
  }
   

