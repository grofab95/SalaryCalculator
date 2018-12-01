namespace SalaryCalculator.SalaryReport
{
    public class MonthSalaryReport
    {
        public MonthSalaryReport(MonthsWorkingHours monthsWorkingHours, Factors factors, CalculateSummary summary)
        {
            var calculator = new Calculator(monthsWorkingHours);
            summary.OverHoursAmount = calculator.CalculateOverhoursAmount(factors.WorkedMonth, factors.WorkedHours);
            summary.OverHoursGrossIncome = calculator.CalculateOverHoursGrossIncome(summary.OverHoursAmount, factors.HourlyFee);
            summary.OverHoursNetIncome = calculator.CalculateOverHoursNetIncome(summary.OverHoursGrossIncome);
            summary.TotalGrossIncome = calculator.CalculateTotalGrossIncome(
                factors.WorkedHours, factors.HourlyFee, summary.OverHoursGrossIncome);
            summary.TotalNetIncome = calculator.CalculateTotalNetIncome(summary.TotalGrossIncome);
        }
    }
}
