namespace SalaryCalculator.SalaryReport
{
    public class MonthSalaryReport
    {
        public readonly Factors Factors;
        public readonly CalculationsSummary Summary;
        public readonly MonthsWorkingHours MonthsWorkingHours;
        public MonthSalaryReport(MonthsWorkingHours monthsWorkingHours, Factors factors)
        {
            var summary = new CalculationsSummary();
            var calculator = new Calculator(monthsWorkingHours);
            Factors = factors;
            Summary = summary;
            MonthsWorkingHours = monthsWorkingHours;
            summary.OverHoursAmount = calculator.CalculateOverhoursAmount(factors.WorkedMonth, factors.WorkedHours);
            summary.OverHoursGrossIncome = calculator.CalculateOverHoursGrossIncome(summary.OverHoursAmount, factors.HourlyFee);
            summary.OverHoursNetIncome = calculator.CalculateOverHoursNetIncome(summary.OverHoursGrossIncome);
            summary.TotalGrossIncome = calculator.CalculateTotalGrossIncome(
                factors.WorkedHours, factors.HourlyFee, summary.OverHoursGrossIncome);
            summary.TotalNetIncome = calculator.CalculateTotalNetIncome(summary.TotalGrossIncome);
        }
    }
}
