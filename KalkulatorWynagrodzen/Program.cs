using System;
using System.Collections.Generic;
using Parsers;
using SalaryCalculator.Desktop;
using SalaryCalculator.SalaryReport;

namespace SalaryCalculator.Console
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine("PROGRAM DO OBLICZANIA WYNAGRODZENIA ZA NADGODZINY (DODATEK 50%)\n");
                    var monthsWorkingHoursConfiguration
                        = JsonFileConverter.JsonFileConverter.ConvertFromFile<Dictionary<int, int>>("MonthConfig.json");
                    var monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
                    var factors = new Factors
                    {
                        WorkedHours = UserInputConsoleReader.ReadWorkedHours(),
                        HourlyFee = UserInputConsoleReader.ReadHourlyFee(),
                        WorkedMonth = UserInputConsoleReader.ReadMonth()
                    };
                    var monthSalaryReport = new MonthSalaryReport(monthsWorkingHours, factors);
                    var textReport = new SimpleTextReportBuilder()
                        .BuildMonthlyReport(monthSalaryReport);
                    System.Console.WriteLine(textReport);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(
                        $"Wystąpił błąd: {ex.Message}{Environment.NewLine}");
                    System.Console.WriteLine("----------------------------------------------------------------");
                    Main();
                }
            }
        }
    }
}

