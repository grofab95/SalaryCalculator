﻿using System;

namespace Console
{
    internal static class UserInputConsoleReader
    {
        public static double ReadWorkedHours()
        {
            System.Console.Write("Podaj liczbę godzin: ");
            var userInput = System.Console.ReadLine();
            return double.Parse(userInput ?? throw new InvalidOperationException());         
        }
        public static double ReadHourlyFee()
        {
            System.Console.Write("Podaj stawkę godzinową (brutto w zł): ");
            var userInput = System.Console.ReadLine();
            return double.Parse(userInput ?? throw new InvalidOperationException());
        }
        public static int ReadMonth()
        {
            System.Console.Write("Podaj numer miesiąca (1-12): ");
            var userInput = System.Console.ReadLine();
            return int.Parse(userInput ?? throw new InvalidOperationException());
        }
    }
}
