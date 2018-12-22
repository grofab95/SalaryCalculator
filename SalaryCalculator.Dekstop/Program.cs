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

        private static void HandleAnticipatedErrors(object sender, ThreadExceptionEventArgs exceptionEventArgs) =>
            MessageBox.Show(exceptionEventArgs.Exception.Message, 
                TextualRessources.Error, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);

        private static void HandleUnanticipatedErrors(object sender,
            UnhandledExceptionEventArgs exceptionEventArgs) => 
            MessageBox.Show(((Exception)exceptionEventArgs.ExceptionObject).Message, 
                TextualRessources.FatalError, 
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
    }  
}
