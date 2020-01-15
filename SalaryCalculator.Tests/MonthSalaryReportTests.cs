using SalaryCalculator.SalaryReport;
using System.Collections.Generic;
using Xunit;

namespace SalaryCalculator.Tests
{
    public class MonthSalaryReportTests
    {
        private readonly MonthSalaryReport _monthSalaryReport;

        public MonthSalaryReportTests()
        {
            var monthsWorkingHours = new MonthsWorkingHours(
                new Dictionary<int, int> { 
                    { 1, 150 } 
                });

            var factors = new Factors() 
            { 
                HourlyFee = 13, 
                WorkedHours = 180, 
                WorkedMonth = 1 
            };

            _monthSalaryReport = new MonthSalaryReport(monthsWorkingHours, factors);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryOverHoursAmount_Equal_NotNull()
        {
            Assert.False(_monthSalaryReport.Summary.OverHoursAmount == 0);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryOverHoursGrossIncome_Equal_NotNull()
        {
            Assert.False(_monthSalaryReport.Summary.OverHoursGrossIncome == 0);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryOverHoursNetIncomet_Equal_NotNull()
        {
            Assert.False(_monthSalaryReport.Summary.OverHoursNetIncome == 0);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryTotalGrossIncome_Equal_NotNull()
        {
            Assert.False(_monthSalaryReport.Summary.TotalGrossIncome == 0);
        }

        [Fact]
        public void MonthSalaryReport_For_SummaryTotalNetIncome_Equal_NotNull()
        {
            Assert.False(_monthSalaryReport.Summary.TotalNetIncome == 0);
        }
    }
}
