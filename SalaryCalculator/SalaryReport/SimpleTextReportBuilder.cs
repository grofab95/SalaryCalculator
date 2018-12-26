using System;
using System.Text;

namespace SalaryCalculator.SalaryReport
{
    public class SimpleTextReportBuilder
    {
        public string BuildMonthlyReport(MonthSalaryReport monthSalaryReport)
        {
            var report = new StringBuilder();
            report
                .AppendLine(Environment.NewLine)
                .AppendLine($"Podsumowanie dla miesiąca {Month.NumberToName(monthSalaryReport.Factors.WorkedMonth)} :")
                .AppendLine("")
                .AppendLine(
                    $"Wymiar czasu pracy w tym miesiącu: {monthSalaryReport.MonthsWorkingHours[monthSalaryReport.Factors.WorkedMonth]}h, " +
                    $"Przepracowano: {monthSalaryReport.Factors.WorkedHours}h")
                .AppendLine($"Stawka godzinowa (brutto): {monthSalaryReport.Factors.HourlyFee}zł {Environment.NewLine}")
                .AppendLine($"Liczba nadgodzin: {monthSalaryReport.Summary.OverHoursAmount}, " +
                $"wynagrodzenie brutto: {monthSalaryReport.Summary.OverHoursGrossIncome}zł")
                .AppendLine($"Liczba nadgodzin: {monthSalaryReport.Summary.OverHoursAmount}, " +
                $"wynagrodzenie netto: {monthSalaryReport.Summary.OverHoursNetIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite brutto (podstawa + nadgodziny): {monthSalaryReport.Summary.TotalGrossIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite netto (podstawa + nadgodziny): {monthSalaryReport.Summary.TotalNetIncome}zł")
                .AppendLine("")
                .AppendLine(Environment.NewLine);
            return report.ToString();
        }
    }
}
