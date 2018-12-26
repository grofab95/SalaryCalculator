using System.Globalization;

namespace SalaryCalculator.Desktop
{
    public static class LanguageSwitch
    {
        public static void ToPolish()
        {
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture("pl");
        }

        public static void ToEnglish()
        {
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
        }
    }
}
