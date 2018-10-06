namespace SalaryCalculator.Exceptions
{
    public class InvalidMonth : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Niepoprawny miesiąc";

        public InvalidMonth() : base(exceptionMessage)
        { }
    }
}
