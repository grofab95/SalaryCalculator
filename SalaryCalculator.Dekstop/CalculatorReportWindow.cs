using System;
using System.Windows.Forms;

namespace SalaryCalculator.Desktop
{
    public partial class CalculatorReportWindow : Form
    {
        public CalculatorReportWindow(string reportFromMainWindows)
        {
            InitializeComponent();
            report_textBox.Text = reportFromMainWindows;
        }

        private void BackToMainWindow_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
