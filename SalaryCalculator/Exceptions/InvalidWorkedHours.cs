namespace SalaryCalculator.Exceptions
{
    public class InvalidWorkedHours : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Niepoprawna liczba roboczogodzin.";

        public InvalidWorkedHours() : base(exceptionMessage)
        { }
    }
}

