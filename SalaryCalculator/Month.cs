using System;

namespace SalaryCalculator
{
    public static class Month
    {
        private static readonly string[] MonthsNames = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec",
            "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };

        public static string NumberToName(int monthNumber) => MonthsNames[monthNumber - 1];

        public static int NameToNumber(string monthName) => Array.IndexOf(MonthsNames, monthName);
    }
}
