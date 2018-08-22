using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorWynagrodzen
{
    class Program
    {
        static void Main()
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
                    var overHoursAmount = FeCalculator.CalculateOverhoursAmount(workedMonth, workedHours);
                    var overHoursGrossIncome = FeCalculator.CalculateOverHoursGrossIncome(overHoursAmount, hourlyFee);
                    var overHoursNetIncome = FeCalculator.CalculateOverHoursNetIncome(overHoursGrossIncome);
                    var totalGrossIncome = FeCalculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
                    var totalNetIncome = FeCalculator.CalculateTotalNetIncome(totalGrossIncome);
                    // Report
                    var report = ReportBuilder.BuildIncomeMonthlyReport(
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
    class UserInputConverter
    {
        public static double ReadWorkedHours()
        {
            Console.Write("Podaj liczbę godzin: ");
            var userInput = Console.ReadLine();
            return double.TryParse(userInput, out var workedHours) && workedHours > 0 && workedHours < 300
                ? workedHours
                : throw new ArgumentException($"Niepoprawna wartość dla argumentu {workedHours}", nameof(workedHours));
        }
        public static double ReadHourlyFee()
        {
            Console.Write("Podaj stawkę godzinową (brutto w zł): ");
            var userInput = Console.ReadLine();
            return double.TryParse(userInput, out var hourlyFee) && hourlyFee > 0 && hourlyFee < 10000
                ? hourlyFee
                : throw new ArgumentException($"Niepoprawna wartość dla argumentu {hourlyFee}", nameof(hourlyFee));
        }
        public static Month ReadMonth()
        {
            Console.Write("Podaj numer miesiąca (1-12): ");
            var userInput = Console.ReadLine();
            var monthNumber = short.TryParse(userInput, out var workedMonth) && workedMonth > 0 && workedMonth < 13
                ? workedMonth
                : throw new ArgumentException($"Niepoprawna wartość dla argumentu {workedMonth}", nameof(workedMonth));
            return (Month)monthNumber;
        }
    }
    class MonthMaps
    {
        public static readonly IReadOnlyDictionary<Month, int> MonthWorkingHours = new Dictionary<Month, int>
        {
            {Month.Styczeń, 168},
            {Month.Luty, 160},
            {Month.Marzec, 176},
            {Month.Kwiecień, 160},
            {Month.Maj, 160},
            {Month.Czerwiec, 168},
            {Month.Lipiec, 176},
            {Month.Sierpień, 176},
            {Month.Wrzesień, 160},
            {Month.Październik, 184},
            {Month.Listopad, 168},
            {Month.Grudzień, 152},
        };
    }
    class Multipliers
    {
        public const float OverHoursMultiplayer = 1.5F;
        public const float NetToGrossIncomeFactor = 0.75F;
    }
    class FeCalculator
    {
        public static double CalculateOverhoursAmount(Month workedMonth, double workedHours) =>
            MonthMaps.MonthWorkingHours[workedMonth] < workedHours
                ? workedHours - MonthMaps.MonthWorkingHours[workedMonth]
                : 0;

        public static double CalculateTotalNetIncome(double totalGrossIncome) =>
            Math.Round(totalGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public static double CalculateTotalGrossIncome(
            double workedHours,
            double hourlyFee,
            double overHoursGrossIncome) =>
            Math.Round(workedHours * hourlyFee + overHoursGrossIncome, 2);

        public static double CalculateOverHoursNetIncome(double overHoursGrossIncome) =>
            Math.Round(overHoursGrossIncome * Multipliers.NetToGrossIncomeFactor, 2);

        public static double CalculateOverHoursGrossIncome(double overHoursAmount, double hourlyFee) =>
            Math.Round(hourlyFee * overHoursAmount * Multipliers.OverHoursMultiplayer, 2);
    }
    class WorkingDaysFromConfigFile
    {

    }
    class ReportBuilder
    {
        public static string BuildIncomeMonthlyReport(
           double workedHours,
           Month workedMonth,
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
                .AppendLine($"PODSUMOWANIE dla miesiąca {workedMonth.ToString()} :")
                .AppendLine("------------------------------------------------------------------")
                .AppendLine(
                    $"Wymiar czasu pracy w tym miesiącu: {MonthMaps.MonthWorkingHours[workedMonth]}h, Przepracowano: {workedHours}h")
                .AppendLine($"Stawka godzinowa (brutto): {hourlyFee}zł {Environment.NewLine}")
                .AppendLine($"Liczba nadgodzin: {overHoursAmount}, wynagrodzenie brutto: {overHoursGrossIncome}zł")
                .AppendLine($"Liczba nadgodzin: {overHoursAmount}, wynagrodzenie netto: {overHoursNetIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite brutto (podstawa + nadgodziny): {totalGrossIncome}zł")
                .AppendLine($"Wynagrodzenie całkowite netto (podstawa + nadgodziny): {totalNetIncome}zł")
                .AppendLine("------------------------------------------------------------------")
                .AppendLine(Environment.NewLine);
            return reportBuilder.ToString();
        }
    }
}
