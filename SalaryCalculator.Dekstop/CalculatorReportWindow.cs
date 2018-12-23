using System;
using System.Windows.Forms;

namespace SalaryCalculator.Desktop
{
    public partial class CalculatorReportWindow : Form
    {
        public CalculatorReportWindow(string reportText)
        {
            InitializeComponent();
            report_textBox.Text = reportText;
        }

        private void BackToMainWindow_Button_Click(object sender, EventArgs e) => Close();
    }
}
