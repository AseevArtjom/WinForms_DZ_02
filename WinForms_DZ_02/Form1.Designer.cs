namespace WinForms_DZ_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.radioButtonMonths = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(279, 89);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(205, 23);
            this.textBoxDate.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(279, 192);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(205, 23);
            this.textBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(332, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Location = new System.Drawing.Point(231, 235);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(52, 19);
            this.radioButtonYears.TabIndex = 4;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Years";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            this.radioButtonMonths.AutoSize = true;
            this.radioButtonMonths.Location = new System.Drawing.Point(284, 235);
            this.radioButtonMonths.Name = "radioButtonMonths";
            this.radioButtonMonths.Size = new System.Drawing.Size(66, 19);
            this.radioButtonMonths.TabIndex = 5;
            this.radioButtonMonths.TabStop = true;
            this.radioButtonMonths.Text = "Months";
            this.radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(350, 235);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(50, 19);
            this.radioButtonDays.TabIndex = 6;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Days";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeconds
            // 
            this.radioButtonSeconds.AutoSize = true;
            this.radioButtonSeconds.Location = new System.Drawing.Point(480, 235);
            this.radioButtonSeconds.Name = "radioButtonSeconds";
            this.radioButtonSeconds.Size = new System.Drawing.Size(69, 19);
            this.radioButtonSeconds.TabIndex = 7;
            this.radioButtonSeconds.TabStop = true;
            this.radioButtonSeconds.Text = "Seconds";
            this.radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Location = new System.Drawing.Point(406, 235);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(68, 19);
            this.radioButtonMinutes.TabIndex = 8;
            this.radioButtonMinutes.TabStop = true;
            this.radioButtonMinutes.Text = "Minutes";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(310, 269);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(149, 38);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Расчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioButtonMinutes);
            this.Controls.Add(this.radioButtonSeconds);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.radioButtonMonths);
            this.Controls.Add(this.radioButtonYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDate;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
        private RadioButton radioButtonYears;
        private RadioButton radioButtonMonths;
        private RadioButton radioButtonDays;
        private RadioButton radioButtonSeconds;
        private RadioButton radioButtonMinutes;
        private Button buttonCalculate;
    }
}