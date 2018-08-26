using System;

namespace KalkulatorWynagrodzen
{
    class Program
    {
        static void Main()
        {
            TestFile testResult = new TestFile();
            int TestResult = testResult.VerifyFile();
            if (TestResult == 0)
            {
                Console.ReadKey();
            }
            else
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("PROGRAM DO OBLICZANIA WYNAGRODZENIA ZA NADGODZINY (DODATEK 50%)\n");
                        // Read user data
                        var workedHours = UserInputConverter.ReadWorkedHours();
                        var workedMonth = UserInputConverter.ReadMonth();
                        var hourlyFee = UserInputConverter.ReadHourlyFee();
                        // Calculate
                        FeCalculator OverHoursAmount = new FeCalculator();
                        FeCalculator OverHoursGrossIncome = new FeCalculator();
                        FeCalculator OverHoursNetIncomeO = new FeCalculator();
                        FeCalculator TotalGrossIncome = new FeCalculator();
                        FeCalculator TotalNetIncome = new FeCalculator();
                        var overHoursAmount = OverHoursAmount.CalculateOverhoursAmount(workedMonth, workedHours);
                        var overHoursGrossIncome = OverHoursGrossIncome.CalculateOverHoursGrossIncome(overHoursAmount, hourlyFee);
                        var overHoursNetIncome = OverHoursNetIncomeO.CalculateOverHoursNetIncome(overHoursGrossIncome);
                        var totalGrossIncome = TotalGrossIncome.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
                        var totalNetIncome = TotalNetIncome.CalculateTotalNetIncome(totalGrossIncome);
                        // Report
                        ReportBuilder Report = new ReportBuilder();
                        var report = Report.BuildIncomeMonthlyReport(
                                workedHours,
                                workedMonth,
                                hourlyFee,
                                overHoursAmount,
                                overHoursGrossIncome,
                                overHoursNetIncome,
                                totalGrossIncome,
                                totalNetIncome
                            );
                        Console.WriteLine(report);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(
                            $"Wystąpił błąd, działanie aplikacji zostanie wznowione! Błąd: {ex.Message}{Environment.NewLine}");
                    }
                }
            }
            
        }
    }
}

