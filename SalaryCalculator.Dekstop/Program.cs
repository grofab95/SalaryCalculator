using SalaryCalculator.Desktop.Ressources;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SalaryCalculator.Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += HandleAnticipatedErrors;
            AppDomain.CurrentDomain.UnhandledException += HandleUnanticipatedErrors;
            Application.Run(new CalculatorMainWindow());
        }

        private static void HandleAnticipatedErrors(object sender, ThreadExceptionEventArgs exceptionEventArgs)
        {
            var messageError = "";
            switch (exceptionEventArgs.Exception.GetType())
            {
                case var exceptionType when exceptionType == typeof (Exceptions.InvalidMonth):
                    messageError = Ressources.Errors.ErrorMessages.InvalidMonth;
                    break;
                case var exceptionType when exceptionType == typeof(Exceptions.InvalidHourlyFee):
                    messageError = Ressources.Errors.ErrorMessages.InvalidHourlyFee;
                    break;
                case var exceptionType when exceptionType == typeof(Exceptions.InvalidWorkedHours):
                    messageError = Ressources.Errors.ErrorMessages.InvalidWorkedHours;
                    break;
                case var exceptionType when exceptionType == typeof(Exceptions.SalaryCalculatorException):
                    messageError = Ressources.Errors.ErrorMessages.NotTranslatedError;
                    break;
                default:
                    messageError = Ressources.Errors.ErrorMessages.NotSupportedExceptionType;
                    break;
            }
            MessageBox.Show(exceptionEventArgs.Exception.Message,
                TextualRessources.Error,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static void HandleUnanticipatedErrors(object sender,
            UnhandledExceptionEventArgs exceptionEventArgs) => 
            MessageBox.Show(((Exception)exceptionEventArgs.ExceptionObject).Message, 
                TextualRessources.FatalError, 
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
    }  
}
