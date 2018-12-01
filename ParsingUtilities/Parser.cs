using System;

namespace Console
{
    public static class Parser
    {
        public static double ParseStringToDouble(string userInput) => 
            double.Parse(userInput ?? throw new FormatException());
        public static int ParseStringToInt(string userInput) => 
            int.Parse(userInput ?? throw new FormatException());
    }
}
