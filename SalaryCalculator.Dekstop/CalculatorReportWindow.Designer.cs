namespace SalaryCalculator.Desktop
{
    partial class CalculatorReportWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorReportWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMainWindow_Button = new System.Windows.Forms.Button();
            this.report_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.report_textBox);
            this.panel1.Controls.Add(this.BackToMainWindow_Button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 308);
            this.panel1.TabIndex = 7;
            // 
            // BackToMainWindow_Button
            // 
            this.BackToMainWindow_Button.Location = new System.Drawing.Point(4, 4);
            this.BackToMainWindow_Button.Name = "BackToMainWindow_Button";
            this.BackToMainWindow_Button.Size = new System.Drawing.Size(75, 23);
            this.BackToMainWindow_Button.TabIndex = 15;
            this.BackToMainWindow_Button.Text = "Powrót";
            this.BackToMainWindow_Button.UseVisualStyleBackColor = true;
            this.BackToMainWindow_Button.Click += new System.EventHandler(this.BackToMainWindow_Button_Click);
            // 
            // report_textBox
            // 
            this.report_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.report_textBox.Location = new System.Drawing.Point(93, 32);
            this.report_textBox.Multiline = true;
            this.report_textBox.Name = "report_textBox";
            this.report_textBox.ReadOnly = true;
            this.report_textBox.Size = new System.Drawing.Size(515, 258);
            this.report_textBox.TabIndex = 16;
            this.report_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculatorReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 332);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorReportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAM DO OBLICZANIA WYNAGRODZENIA ZA NADGODZINY (DODATEK 50%)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMainWindow_Button;
        private System.Windows.Forms.TextBox report_textBox;
    }
}