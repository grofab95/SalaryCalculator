using System;

namespace SalaryCalculator.Desktop
{ 
    public static class Localizations
    {
        public static void Localize(this CalculatorMainWindow calculatorMainWindow)
        {
            calculatorMainWindow.Text = TextualRessources.CalculatorTitle;
            calculatorMainWindow.Application.Text = TextualRessources.Application;
            calculatorMainWindow.MonthConfiguration.Text = TextualRessources.MonthConfiguration;
            calculatorMainWindow.Language.Text = TextualRessources.Language;
        }

        internal static void Localize(this CalculatorReportWindow calculatorReportWindow)
        {
            throw new NotImplementedException();
        }

        internal static void Localize(this MonthConfigEditorWindow monthConfigEditorWindow)
        {
            throw new NotImplementedException();
        }
    }
}
