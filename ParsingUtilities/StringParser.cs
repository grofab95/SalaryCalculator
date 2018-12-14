using System;

namespace Parsers
{
    public static class StringParser
    {
        public static double StringToDouble(string userInput) => 
            double.Parse(userInput ?? throw new FormatException());

        public static int StringToInt(string userInput) => 
            int.Parse(userInput ?? throw new FormatException());
    }
}
