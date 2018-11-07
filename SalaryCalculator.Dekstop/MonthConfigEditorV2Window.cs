using Console;
using FileTranslator;
using System;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
{
    public partial class MonthConfigEditorV2Window : Form
    {
        private MonthsWorkingHours _monthsWorkingHours;
        private string[] _MonthWorkingHoursTabWithStringValue = new string[13];
        private int[] _MonthWorkingHoursTabWithIntValue = new int[13];

        public MonthConfigEditorV2Window(MonthsWorkingHours monthsWorkingHours)
        {
            _monthsWorkingHours = monthsWorkingHours;
            InitializeComponent();
            CreateLabelsAndFillItWithNumberOfMonthWorkingDays();
            
        }

        private void CreateLabelsAndFillItWithNumberOfMonthWorkingDays()
        {
            Label[] label = new Label[13];
            for (int i = 1; i < label.Length; i++)
            {
                label[i] = new Label();
                if (i + 1 <= 13)
                {
                    label[i].Text = string.Format("{0}", (_monthsWorkingHours[i]));
                    label[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    label[i].Margin = new Padding(0, 1, 0, 6);
                    this.flowLayoutPanel1.Controls.Add((Control)label[i]);
                }                
            }
        }

        private void WriteTextBoxeValuesToTabWithStringValue()
        {
            _MonthWorkingHoursTabWithStringValue[1] = January_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[2] = February_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[3] = March_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[4] = April_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[5] = May_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[6] = June_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[7] = July_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[8] = August_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[9] = September_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[10] = October_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[11] = November_textBox.Text;
            _MonthWorkingHoursTabWithStringValue[12] = December_textBox.Text;
        }

        private void TryAllocateNonEmptyValueFromStringTabToIntTab()
        {
            try
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (_MonthWorkingHoursTabWithStringValue[i] != "")
                    {
                        _MonthWorkingHoursTabWithIntValue[i] =
                            Parser.ParseStringToInt(_MonthWorkingHoursTabWithStringValue[i]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Uwaga!");
            }
        }

        private bool CheckTabWithIntValueForInvalidMonthConfig()
        {
            for (int i = 1; i <= 12; i++)
            {
                if (_MonthWorkingHoursTabWithIntValue[i] > 0)
                {
                    if (_MonthWorkingHoursTabWithIntValue[i] < 100 ||
                        _MonthWorkingHoursTabWithIntValue[i] > 200)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        private void Save_StripMenu_Click_1(object sender, EventArgs e)
        {
            WriteTextBoxeValuesToTabWithStringValue();
            TryAllocateNonEmptyValueFromStringTabToIntTab();
            if (CheckTabWithIntValueForInvalidMonthConfig())
            {
                label13.Text = "OK"; 
                // save method
            } else
            {
                label13.Text = "ERROR"; 
            }
        }

        private void Exit_StripMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
