using System;
using System.Collections.Generic;
using FileTranslator;
using SalaryCalculator;

namespace Console
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
                        = JsonFileTranslator<Dictionary<int, int>>.Translate("MonthConfig.json");
                    var monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
                    // Read user data
                    var workedHours = UserInputConsoleReader.ReadWorkedHours();
                    var workedMonth = UserInputConsoleReader.ReadMonth();
                    var hourlyFee = UserInputConsoleReader.ReadHourlyFee();
                    var calculator = new Calculator(monthsWorkingHours);
                    var overHoursAmount = calculator.CalculateOverhoursAmount(workedMonth, workedHours);
                    var overHoursGrossIncome = calculator.CalculateOverHoursGrossIncome(overHoursAmount, hourlyFee);
                    var overHoursNetIncome = calculator.CalculateOverHoursNetIncome(overHoursGrossIncome);
                    var totalGrossIncome = calculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
                    var totalNetIncome = calculator.CalculateTotalNetIncome(totalGrossIncome);
                    // Report
                    var reportBuilder = new ReportBuilder(monthsWorkingHours);
                    var report = reportBuilder.BuildIncomeMonthlyReport(
                            workedHours,
                            workedMonth,
                            hourlyFee,
                            overHoursAmount,
                            overHoursGrossIncome,
                            overHoursNetIncome,
                            totalGrossIncome,
                            totalNetIncome
                        );
                    System.Console.WriteLine(report);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(
                        $"Wystąpił błąd, działanie aplikacji zostanie zakończone! Błąd: {ex.Message}{Environment.NewLine}");
                    System.Console.ReadKey();
                    break;
                }
            }
        }
    }
}

