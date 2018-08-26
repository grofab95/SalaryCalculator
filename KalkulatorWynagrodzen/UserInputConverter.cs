using System;

namespace KalkulatorWynagrodzen
{
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
}
