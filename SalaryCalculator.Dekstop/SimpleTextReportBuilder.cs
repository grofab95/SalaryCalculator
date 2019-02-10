using SalaryCalculator.SalaryReport;
using System;
using System.Globalization;
using System.Text;

namespace SalaryCalculator.Desktop
{
    public class SimpleTextReportBuilder
    {
        public string BuildMonthlyReport(MonthSalaryReport monthSalaryReport)
        {
            var report = new StringBuilder();
            report
                .AppendLine(Environment.NewLine)
                .AppendLine($"{Ressources.ReportTextualRessources.SummaryForTheMonth} {CultureInfo.DefaultThreadCurrentUICulture.DateTimeFormat.GetMonthName(monthSalaryReport.Factors.WorkedMonth)} :")
                .AppendLine("")
                .AppendLine(
                    $"{Ressources.ReportTextualRessources.TimeDimension}: {monthSalaryReport.MonthsWorkingHours[monthSalaryReport.Factors.WorkedMonth]}h, " +
                    $"{Ressources.ReportTextualRessources.WorkingHours}: {monthSalaryReport.Factors.WorkedHours}h")
                .AppendLine($"{Ressources.ReportTextualRessources.HourlyRateGross}: {monthSalaryReport.Factors.HourlyFee}zł {Environment.NewLine}")
                .AppendLine($"{Ressources.ReportTextualRessources.OvertimeHours} {monthSalaryReport.Summary.OverHoursAmount}, " +
                $"{Ressources.ReportTextualRessources.GrossSalary} {monthSalaryReport.Summary.OverHoursGrossIncome}zł")
                .AppendLine($"{Ressources.ReportTextualRessources.OvertimeHours} {monthSalaryReport.Summary.OverHoursAmount}, " +
                $"{Ressources.ReportTextualRessources.NetSalary} {monthSalaryReport.Summary.OverHoursNetIncome}zł")
                .AppendLine($"{Ressources.ReportTextualRessources.TotalGrossSalary} {monthSalaryReport.Summary.TotalGrossIncome}zł")
                .AppendLine($"{Ressources.ReportTextualRessources.TotalNetSalary} {monthSalaryReport.Summary.TotalNetIncome}zł")
                .AppendLine("")
                .AppendLine(Environment.NewLine);
            return report.ToString();
        }
    }
}