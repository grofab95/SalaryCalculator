using System;

namespace Console
{
    static class StringParser
    {
        public static double ParseToDoubleReadWorkedHours(string userInput) => 
            double.Parse(userInput ?? throw new InvalidOperationException());
        public static double ParseToDoubleReadHourlyFee(string userInput) => 
            double.Parse(userInput ?? throw new InvalidOperationException());
        public static int ParseToIntReadMonth(string userInput) => 
            int.Parse(userInput ?? throw new InvalidOperationException());
    }
}
