using FileTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator.Dekstop
{
    public partial class Form3 : Form
    {

        private string filePath = "monthConfig.json";

        public Form3()
        {
            InitializeComponent();
            openFile();
        }

        private void openFile()
        {
            var file = new StreamReader(filePath);
            textBox1.Text = file.ReadToEnd();
            file.Close();
        }
        private void zamknijToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             var monthsWorkingHoursConfiguration
                          = JsonFileTranslator<Dictionary<int, int>>.Translate("MonthConfig.json");
             var monthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
             var form4 = new Form4(monthsWorkingHours);
             form4.Hide();
             var suma = monthsWorkingHours[1] + 10;
             var file = new StreamReader(filePath);
             var oldFileValue = file.ReadToEnd();
             var newFileValue = textBox1.Text;
             file.Close();
             if (newFileValue == oldFileValue)
             {
                 MessageBox.Show("Nie wprowadzono żadnych zmian.", "Info");
             }
             else
             {
                 using (StreamWriter newTask = new StreamWriter(filePath, false))
                 {
                     newTask.WriteLine(textBox1.Text);
                 }
                 openFile();
                 MessageBox.Show("Zmiany zostały zapisane.", "Info");
             }           
}

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz przywrócić wartości domyślne", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var fileDefault = new StreamReader("MonthConfigDefault.json");
                var fileDefaultValue = fileDefault.ReadToEnd();
                using (StreamWriter newTask = new StreamWriter(filePath, false))
                {
                    newTask.WriteLine(fileDefaultValue);
                }
                MessageBox.Show("Domyślne wartości zostały przywrócone i zapisane.", "Info");
                openFile();
                fileDefault.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
