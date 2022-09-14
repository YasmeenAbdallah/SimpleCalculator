using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Models
{
    public class CalculationResultsModel
    {
      /// <summary>
      /// the result of summation
      /// </summary>
        public string Summation { get; set; }

       
        /// <summary>
        /// the results for Multiplication
        /// </summary>
        public string Multiplication { get; set; }

       
        /// <summary>
        /// the results for Subtraction
        /// </summary>
        public string Subtraction { get; set; }

        
        /// <summary>
        /// the results for Divivsion
        /// </summary>
        public string Divivsion { get; set; }
    }
}
