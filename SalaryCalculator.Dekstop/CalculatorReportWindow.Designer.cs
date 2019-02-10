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
            this.report_textBox = new System.Windows.Forms.TextBox();
            this.Return_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.report_textBox);
            this.panel1.Controls.Add(this.Return_Button);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // report_textBox
            // 
            resources.ApplyResources(this.report_textBox, "report_textBox");
            this.report_textBox.Name = "report_textBox";
            this.report_textBox.ReadOnly = true;
            // 
            // Return_Button
            // 
            resources.ApplyResources(this.Return_Button, "Return_Button");
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.BackToMainWindow_Button_Click);
            // 
            // CalculatorReportWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorReportWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox report_textBox;
        protected internal System.Windows.Forms.Button Return_Button;
    }
}