using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console;
using FileTranslator;

namespace SalaryCalculator.Dekstop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HourlyFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var WorkedHoursFromTextBox = textBox1.Text;
                var HourlyFeeFromTextBox = HourlyFee.Text;
                var workedHours = Parser.ParseStringToDouble(WorkedHoursFromTextBox);
                var hourlyFee = Parser.ParseStringToDouble(HourlyFeeFromTextBox);
                var workedMonth = comboBox1.SelectedIndex;
                workedMonth += 1;
                var monthsWorkingHoursConfiguration
                           = JsonFileTranslator<Dictionary<int, int>>.Translate("MonthConfig.json");
                var monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
                var calculator = new Calculator(monthsWorkingHours);
                var overHoursAmount = calculator.CalculateOverhoursAmount(workedMonth, workedHours);
                var overHoursGrossIncome = calculator.CalculateOverHoursGrossIncome(overHoursAmount, hourlyFee);
                var overHoursNetIncome = calculator.CalculateOverHoursNetIncome(overHoursGrossIncome);
                var totalGrossIncome = calculator.CalculateTotalGrossIncome(workedHours, hourlyFee, overHoursGrossIncome);
                var totalNetIncome = calculator.CalculateTotalNetIncome(totalGrossIncome);
                var reportBuilder = new ReportBuilder(monthsWorkingHours);
                var report = reportBuilder.BuildIncomeMonthlyReport(
                        workedHours,
                        workedMonth,
                        hourlyFee,
                        overHoursAmount,
                        overHoursGrossIncome,
                        overHoursNetIncome,
                        totalGrossIncome,
                        totalNetIncome
                    );
                var form2 = new Form2(report);
                form2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "BŁĄD!!!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Fabian Grochla \n" +
                            "Wersja: 1.0");
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthConfigToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }
            

        private void monthConfigV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var monthsWorkingHoursConfiguration
                          = JsonFileTranslator<Dictionary<int, int>>.Translate("MonthConfig.json");
                 var monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
                 var form4 = new Form4(monthsWorkingHours);
                 form4.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "BŁĄD!!!");
            }
}
    }       
}
