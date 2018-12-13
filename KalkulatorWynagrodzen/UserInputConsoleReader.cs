using System;

namespace Parsers
{
    internal static class UserInputConsoleReader
    {
        public static double ReadWorkedHours()
        {
            System.Console.Write("Podaj liczbę godzin: ");
            var userInput = System.Console.ReadLine();
            return StringParser.StringToDouble(userInput);
        }
        public static double ReadHourlyFee()
        {
            System.Console.Write("Podaj stawkę godzinową (brutto w zł): ");
            var userInput = System.Console.ReadLine();
            return StringParser.StringToDouble(userInput);
        }
        public static int ReadMonth()
        {
            System.Console.Write("Podaj numer miesiąca (1-12): ");
            var userInput = System.Console.ReadLine();
            return StringParser.StringToInt(userInput);
        }
    }
}
