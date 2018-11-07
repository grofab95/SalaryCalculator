using System;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorMainWindow());
        }
    }  
}
