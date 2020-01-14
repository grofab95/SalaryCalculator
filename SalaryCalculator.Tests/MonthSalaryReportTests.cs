using SalaryCalculator.SalaryReport;
using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class MonthSalaryReportTests
    {
        private readonly MonthSalaryReport _monthSalaryReport;
        private readonly Calculator _calculator;
        private readonly Factors _factors;

        public MonthSalaryReportTests()
        {
            var monthsWorkingHours = new MonthsWorkingHours(
                new Dictionary<int, int> { 
                    { 1, 150 } 
                });

            _factors = new Factors() 
            { 
                HourlyFee = 13, 
                WorkedHours = 180, 
                WorkedMonth = 1 
            };

            _monthSalaryReport = new MonthSalaryReport(monthsWorkingHours, _factors);
            _calculator = new Calculator(monthsWorkingHours);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryOverHoursAmount_Equal_OverHoursAmount()
        {
            Assert.False(_monthSalaryReport.Summary.OverHoursAmount == 0);
        }
    }
}
