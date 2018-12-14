using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalaryCalculator.Desktop
{
    public partial class MessageBoxForEditorV2 : Form
    {
        public MessageBoxForEditorV2()
        {
            InitializeComponent();
        }

        public void PrintMessage(string InputError, string HoursConfigError, string SameValueError)
        {
            InputError_label.BackColor = Color.Yellow;
            InputError_label.Text = $"{HoursConfigError}";
            HoursConfigError_label.BackColor = Color.Red;
            HoursConfigError_label.Text = $"{InputError}";
            SameValueError_label.BackColor = Color.LightBlue;
            SameValueError_label.Text = $"{SameValueError}";
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
