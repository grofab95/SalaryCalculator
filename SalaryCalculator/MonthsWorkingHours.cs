using System.Collections.Generic;

namespace SalaryCalculator
{
    public class MonthsWorkingHours
    {
        private readonly Dictionary<int, int> _monthsWorkingHoursDictionary;
        private const int MaxWorkingHoursPerMonth = 200;
        private const int MinWorkingHoursPerMonth = 100;
        public MonthsWorkingHours(Dictionary<int, int> monthsWorkingHoursDictionary)
        {
            ValidateConfiguration(monthsWorkingHoursDictionary);
            _monthsWorkingHoursDictionary = monthsWorkingHoursDictionary;
        }
        private static void ValidateConfiguration(Dictionary<int, int> monthsWorkingHours)
        {
            foreach (var monthsWorkingHour in monthsWorkingHours)
            {
                ValidateMonthNumberRange(monthsWorkingHour.Key);
                ValidateWorkingHoursRange(monthsWorkingHour.Value);
            }
        }

        private static void ValidateWorkingHoursRange(int workingHours)
        {
            if (workingHours > MaxWorkingHoursPerMonth ||
                workingHours < MinWorkingHoursPerMonth)
            {
                throw new InvalidMonthWorkingHoursConfiguration();
            }
        }

        private static void ValidateMonthNumberRange(int monthNumber)
        {
            if (monthNumber > 12 || monthNumber < 1)
            {
                throw new InvalidMonthWorkingHoursConfiguration();
            }
        }

        public int this[int key] => _monthsWorkingHoursDictionary[key];
    }
}
