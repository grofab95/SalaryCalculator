using System;
using System.Text;

namespace SalaryCalculator.SalaryReport
{
    public class SimpleTextReportBuilder
    {
        public string BuildMontlhyReport(MonthsWorkingHours monthsWorkingHours, Factors factors, CalculateSummary summary)
        {
            var report = new StringBuilder();
            report
                .AppendLine(Environment.NewLine)
                .AppendLine($"Podsumowanie dla miesiąca {Month.NumberToName(factors.WorkedMonth)} :")
                .AppendLine(" ")
                .AppendLine(
                    $"Wymiar czasu pracy w tym miesiącu: {monthsWorkingHours[factors.WorkedMonth]}h, Przepracowano: {factors.WorkedHours}h")
                .AppendLine($"Stawka godzinowa (brutto): {factors.HourlyFee}zł {Environment.NewLine}")
                .AppendLine($"Liczba nadgodzin: {summary.OverHoursAmount}, wynagrodzenie brutto: {summary.OverHoursGrossIncome}zł")
                .AppendLine($"Liczba nadgodzin: {summary.OverHoursAmount}, wynagrodzenie netto: {summary.OverHoursNetIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite brutto (podstawa + nadgodziny): {summary.TotalGrossIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite netto (podstawa + nadgodziny): {summary.TotalNetIncome}zł")
                .AppendLine("")
                .AppendLine(Environment.NewLine);
            return report.ToString();
        }
    }
}
