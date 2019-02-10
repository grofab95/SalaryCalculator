using System;

namespace SalaryCalculator.Exceptions
{
    public class SalaryCalculatorException: Exception
    {
        protected SalaryCalculatorException(string exceptionMessage) : base(exceptionMessage)
        {
        }
    }
}
