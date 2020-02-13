using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parsers;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaryCalculatorController : ControllerBase
    {
        private MonthsWorkingHours _monthsWorkingHours;
        private CalculationsSummary _summary;
        private Calculator _calculator;

        public SalaryCalculatorController(
            MonthsWorkingHours monthsWorkingHours,
            CalculationsSummary calculationsSummary,
            Calculator calculator)
        {
            _monthsWorkingHours = monthsWorkingHours;
            _summary = calculationsSummary;
            _calculator = calculator;
        }

        [HttpGet]
        public IActionResult GetMonthsWorkingHours()
        {
            var MonthsWorkingHoursList = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                MonthsWorkingHoursList.Add(_monthsWorkingHours[i]);
            }
            return Ok(MonthsWorkingHoursList);
        }

        [HttpPost]
        public IActionResult Calculate([FromBody]Factors factors)
        {
            try
            {
                StringParser.StringToDouble(factors.WorkedMonth.ToString());
                StringParser.StringToDouble(factors.HourlyFee.ToString());
                _summary.OverHoursAmount = _calculator.CalculateOverhoursAmount(factors.WorkedMonth, factors.WorkedHours);
                _summary.OverHoursGrossIncome = _calculator.CalculateOverHoursGrossIncome(_summary.OverHoursAmount, factors.HourlyFee);
                _summary.OverHoursNetIncome = _calculator.CalculateOverHoursNetIncome(_summary.OverHoursGrossIncome);
                _summary.TotalGrossIncome = _calculator.CalculateTotalGrossIncome(
                    factors.WorkedHours, factors.HourlyFee, _summary.OverHoursGrossIncome);
                _summary.TotalNetIncome = _calculator.CalculateTotalNetIncome(_summary.TotalGrossIncome);
                return Ok(_summary);
            }
            catch (Exception excteption)
            {
                return BadRequest(new { message = excteption.Message });
            }
        }
    }
}
