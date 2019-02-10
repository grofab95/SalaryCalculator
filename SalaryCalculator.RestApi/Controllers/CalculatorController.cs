using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SalaryCalculator.RestApi
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult<double> Value(int month, double workedHours)
        {
            var x = new MonthsWorkingHours( new Dictionary<int,int> { {1,160 },
            {2,160 },
            {3,160 },
            {4,160 },
            {5,160 },
            {6,160 },
            {7,160 },
            {8,160 },
            {9,160 },
            {10,160},
            {11,160 },
            {12,160 }
            });
            return new Calculator(x).CalculateOverhoursAmount(month, workedHours);
        }
    }
}
