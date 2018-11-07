using System;
using System.Text;

namespace SalaryCalculator
{
    public class ReportBuilder
    {
        private readonly MonthsWorkingHours _monthsWorkingHours;

        public ReportBuilder(MonthsWorkingHours monthsWorkingHours)
        {
            _monthsWorkingHours = monthsWorkingHours;
        }

        public string BuildIncomeMonthlyReport(
           double workedHours,
           int workedMonth,
           double hourlyFee,
           double overHoursAmount,
           double overHoursGrossIncome,
           double overHoursNetIncome,
           double totalGrossIncome,
           double totalNetIncome)
        {
            var reportBuilder = new StringBuilder();
            reportBuilder
                .AppendLine(Environment.NewLine)
                .AppendLine($"Podsumowanie dla miesiąca {Month.NumberToName(workedMonth)} :")
                .AppendLine("")
                .AppendLine(
                    $"Wymiar czasu pracy w tym miesiącu: {_monthsWorkingHours[workedMonth]}h, Przepracowano: {workedHours}h")
                .AppendLine($"Stawka godzinowa (brutto): {hourlyFee}zł {Environment.NewLine}")
                .AppendLine($"Liczba nadgodzin: {overHoursAmount}, wynagrodzenie brutto: {overHoursGrossIncome}zł")
                .AppendLine($"Liczba nadgodzin: {overHoursAmount}, wynagrodzenie netto: {overHoursNetIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite brutto (podstawa + nadgodziny): {totalGrossIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite netto (podstawa + nadgodziny): {totalNetIncome}zł")
                .AppendLine("")
                .AppendLine(Environment.NewLine);
            return reportBuilder.ToString();
        }
    }
}
