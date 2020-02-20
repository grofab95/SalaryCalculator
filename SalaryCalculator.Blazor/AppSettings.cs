using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Blazor
{
    public class AppSettings
    {
        public MonthsWorkingHours MonthsWorkingHours { get; set; }
        public CalculationsSummary CalculationsSummary { get; set; }
        public Calculator Calculator { get; set; }
        public MonthSalaryReport MonthSalaryReport { get; set; }
    }
}
