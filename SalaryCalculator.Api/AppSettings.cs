using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Api
{
    public class AppSettings
    {
        public MonthsWorkingHours MonthsWorkingHours { get; set; }
        public CalculationsSummary CalculationsSummary { get; set; }
        public Calculator Calculator { get; set; }
    }
}
