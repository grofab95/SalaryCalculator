namespace SalaryCalculator.Exceptions
{
    public class InvalidWorkedHours : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Invalid number of worked hours.";

        public InvalidWorkedHours() : base(exceptionMessage)
        { }
    }
}

