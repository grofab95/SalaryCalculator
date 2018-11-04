namespace SalaryCalculator.Dekstop
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
            this.Report_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToMainWindow_Button);
            this.panel1.Controls.Add(this.Report_Label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 359);
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
            // Report_Label
            // 
            this.Report_Label.AutoSize = true;
            this.Report_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Report_Label.Location = new System.Drawing.Point(70, 30);
            this.Report_Label.Name = "Report_Label";
            this.Report_Label.Size = new System.Drawing.Size(108, 22);
            this.Report_Label.TabIndex = 8;
            this.Report_Label.Text = "ReportLabel";
            // 
            // CalculatorReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 379);
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
        private System.Windows.Forms.Label Report_Label;
        private System.Windows.Forms.Button BackToMainWindow_Button;
    }
}