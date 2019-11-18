namespace SalaryCalculator.Exceptions
{
    public class InvalidMonth : SalaryCalculatorException
    {
        private static string exceptionMessage =
            "Invalid month";

        public InvalidMonth() : base(exceptionMessage)
        { }
    }
}
