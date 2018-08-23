using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KalkulatorWynagrodzen
{
    class Program
    {
        static void Main()
        {
            var TestResult = ConfigFile.TestFile();
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
        public static int ReadMonth()
        {
            Console.Write("Podaj numer miesiąca (1-12): ");
            var userInput = Console.ReadLine();
            var monthNumber = int.TryParse(userInput, out var workedMonth) && workedMonth > 0 && workedMonth < 13
                ? workedMonth
                : throw new ArgumentException($"Niepoprawna wartość dla argumentu {workedMonth}", nameof(workedMonth));
            return monthNumber;
        }
    }
    class ConfigFile
    {
        public static String SetupFile()
        {
            var path = @"MonthConfig.json";
            var data = File.ReadAllText(path);
            return data;
        }
        public static int TestFile()
        {
            int[] DebugTable = new int[13];
            var TestResult = 1;
            for (int i = 1; i <= 12; i++)
            {
                int NumberHoursInMonth = WorkingDaysFromConfigFile.GetWorkingHoursOfMonth(i);
                if (NumberHoursInMonth < 100 || NumberHoursInMonth > 200 || NumberHoursInMonth == 0)
                {
                    DebugTable[i] = NumberHoursInMonth;
                    TestResult = 0;
                }
                if (i == 12)
                {
                    break;
                }
            }
            if (TestResult == 0)
            {
                Console.Write($"\nProgram nie mógł zostać uruchomiony, ponieważ plik konfiguracyjny \n" +
                    $"'MonthConfig' zawiera niedopuszczalne wartości: \n\n");
                for (int q = 1; q < 13; q++)
                {
                    if (DebugTable[q] > 0)
                    {
                        Console.WriteLine($"Miesiąc: {WorkingDaysFromConfigFile.GetMonthName(q)} = [{DebugTable[q]}] H");
                    }
                }
            }
            return TestResult;
        }
    }
    class WorkingDaysFromConfigFile
    {
        public static string GetMonthName(int month)
        {
            var result = "";
            MonthIlist MonthIlist = JsonConvert.DeserializeObject<MonthIlist>(ConfigFile.SetupFile());
            switch (month)
            {
                case 1:
                    result = (MonthIlist.M1[0]);
                    break;
                case 2:
                    result = (MonthIlist.M2[0]);
                    break;
                case 3:
                    result = (MonthIlist.M3[0]);
                    break;
                case 4:
                    result = (MonthIlist.M4[0]);
                    break;
                case 5:
                    result = (MonthIlist.M5[0]);
                    break;
                case 6:
                    result = (MonthIlist.M6[0]);
                    break;
                case 7:
                    result = (MonthIlist.M7[0]);
                    break;
                case 8:
                    result = (MonthIlist.M8[0]);
                    break;
                case 9:
                    result = (MonthIlist.M9[0]);
                    break;
                case 10:
                    result = (MonthIlist.M10[0]);
                    break;
                case 11:
                    result = (MonthIlist.M11[0]);
                    break;
                case 12:
                    result = (MonthIlist.M12[0]);
                    break;
                default:
                    break;
            }
            return result;
        }
        public static int GetWorkingHoursOfMonth(int month)
        {
            var result = "";
            MonthIlist MonthIlist = JsonConvert.DeserializeObject<MonthIlist>(ConfigFile.SetupFile());
            switch (month)
            {
                case 1:
                    result = (MonthIlist.M1[1]);
                    break;
                case 2:
                    result = (MonthIlist.M2[1]);
                    break;
                case 3:
                    result = (MonthIlist.M3[1]);
                    break;
                case 4:
                    result = (MonthIlist.M4[1]);
                    break;
                case 5:
                    result = (MonthIlist.M5[1]);
                    break;
                case 6:
                    result = (MonthIlist.M6[1]);
                    break;
                case 7:
                    result = (MonthIlist.M7[1]);
                    break;
                case 8:
                    result = (MonthIlist.M8[1]);
                    break;
                case 9:
                    result = (MonthIlist.M9[1]);
                    break;
                case 10:
                    result = (MonthIlist.M10[1]);
                    break;
                case 11:
                    result = (MonthIlist.M11[1]);
                    break;
                case 12:
                    result = (MonthIlist.M12[1]);
                    break;
                default:
                    break;
            }
            int resultInt = Int32.Parse(result);
            return resultInt;
        }

    }
    public class MonthIlist
    {
        public IList<string> M1 { get; set; }
        public IList<string> M2 { get; set; }
        public IList<string> M3 { get; set; }
        public IList<string> M4 { get; set; }
        public IList<string> M5 { get; set; }
        public IList<string> M6 { get; set; }
        public IList<string> M7 { get; set; }
        public IList<string> M8 { get; set; }
        public IList<string> M9 { get; set; }
        public IList<string> M10 { get; set; }
        public IList<string> M11 { get; set; }
        public IList<string> M12 { get; set; }
    }
    class Multipliers
    {
        public const float OverHoursMultiplayer = 1.5F;
        public const float NetToGrossIncomeFactor = 0.75F;
    }
    class FeCalculator
    {
        public static double CalculateOverhoursAmount(int workedMonth, double workedHours) =>
            WorkingDaysFromConfigFile.GetWorkingHoursOfMonth(workedMonth) < workedHours
                ? workedHours - WorkingDaysFromConfigFile.GetWorkingHoursOfMonth(workedMonth)
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
    class ReportBuilder
    {
        public static string BuildIncomeMonthlyReport(
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
                .AppendLine($"PODSUMOWANIE dla miesiąca {WorkingDaysFromConfigFile.GetMonthName(workedMonth)} :")
                .AppendLine("------------------------------------------------------------------")
                .AppendLine(
                    $"Wymiar czasu pracy w tym miesiącu: {WorkingDaysFromConfigFile.GetWorkingHoursOfMonth(workedMonth)}h, Przepracowano: {workedHours}h")
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

