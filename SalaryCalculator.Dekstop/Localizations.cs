using SalaryCalculator.Desktop.Ressources;

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
            calculatorMainWindow.About_StripMenu.Text = TextualRessources.About;
            calculatorMainWindow.Exit_StripMenu.Text = TextualRessources.Exit;
            calculatorMainWindow.Calculate_Button.Text = TextualRessources.Calculate;
            calculatorMainWindow.MonthSelect_TextBox.Text = TextualRessources.MonthSelect;
            calculatorMainWindow.HourInput_TextBox.Text = TextualRessources.NumberOfHours;
            calculatorMainWindow.HourlyFeeInput_TextBox.Text = TextualRessources.HourlyFee;
            calculatorMainWindow.SetPolishLanguage.Text = TextualRessources.Polish;
            calculatorMainWindow.SetEnglishLanguage.Text = TextualRessources.English;
        }
        internal static void Localize(this CalculatorReportWindow calculatorReportWindow)
        {
            calculatorReportWindow.Text = TextualRessources.Report;
            calculatorReportWindow.Return_Button.Text = TextualRessources.Return;
        }

        internal static void Localize(this MonthConfigEditorWindow monthConfigEditorWindow)
        {
            monthConfigEditorWindow.Text = TextualRessources.MonthConfigEditorTitle;
            monthConfigEditorWindow.Save.Text = TextualRessources.Save;
            monthConfigEditorWindow.Exit.Text = TextualRessources.Exit;
        }
    }
}
