namespace SalaryCalculator.Desktop
{
    partial class MessageBoxForEditorV2
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
            this.ok_button = new System.Windows.Forms.Button();
            this.InputError_label = new System.Windows.Forms.Label();
            this.HoursConfigError_label = new System.Windows.Forms.Label();
            this.SameValueError_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(118, 110);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(111, 39);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // InputError_label
            // 
            this.InputError_label.AutoSize = true;
            this.InputError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InputError_label.Location = new System.Drawing.Point(12, 18);
            this.InputError_label.Name = "InputError_label";
            this.InputError_label.Size = new System.Drawing.Size(74, 20);
            this.InputError_label.TabIndex = 1;
            this.InputError_label.Text = "message";
            this.InputError_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursConfigError_label
            // 
            this.HoursConfigError_label.AutoSize = true;
            this.HoursConfigError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HoursConfigError_label.Location = new System.Drawing.Point(12, 38);
            this.HoursConfigError_label.Name = "HoursConfigError_label";
            this.HoursConfigError_label.Size = new System.Drawing.Size(74, 20);
            this.HoursConfigError_label.TabIndex = 2;
            this.HoursConfigError_label.Text = "message";
            this.HoursConfigError_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SameValueError_label
            // 
            this.SameValueError_label.AutoSize = true;
            this.SameValueError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SameValueError_label.Location = new System.Drawing.Point(12, 58);
            this.SameValueError_label.Name = "SameValueError_label";
            this.SameValueError_label.Size = new System.Drawing.Size(74, 20);
            this.SameValueError_label.TabIndex = 3;
            this.SameValueError_label.Text = "message";
            this.SameValueError_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBoxForEditorV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(345, 181);
            this.ControlBox = false;
            this.Controls.Add(this.SameValueError_label);
            this.Controls.Add(this.HoursConfigError_label);
            this.Controls.Add(this.InputError_label);
            this.Controls.Add(this.ok_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageBoxForEditorV2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uwaga!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label InputError_label;
        private System.Windows.Forms.Label HoursConfigError_label;
        private System.Windows.Forms.Label SameValueError_label;
    }
}