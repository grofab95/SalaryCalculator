using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
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
