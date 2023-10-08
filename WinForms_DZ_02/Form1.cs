using System;
using System.Windows.Forms;

namespace WinForms_DZ_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CalculateTimeRemaining();
        }
        private void CalculateTimeRemaining()
        {
            if (DateTime.TryParse(textBoxDate.Text, out DateTime targetDate))
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan timeRemaining = targetDate - currentDate;

                if (radioButtonYears.Checked)
                {
                    double yearsRemaining = timeRemaining.TotalDays / 365.0;
                    textBoxResult.Text = yearsRemaining.ToString("0.00") + " года";
                }
                else if (radioButtonMonths.Checked)
                {
                    double monthsRemaining = timeRemaining.TotalDays / 30.44;
                    textBoxResult.Text = monthsRemaining.ToString("0.00") + " мес€ца";
                }
                else if (radioButtonDays.Checked)
                {
                    textBoxResult.Text = timeRemaining.TotalDays.ToString("0") + " дней";
                }
                else if (radioButtonMinutes.Checked)
                {
                    textBoxResult.Text = timeRemaining.TotalMinutes.ToString("0") + " минут";
                }
                else if (radioButtonSeconds.Checked)
                {
                    textBoxResult.Text = timeRemaining.TotalSeconds.ToString("0") + " секунд";
                }
            }
            else
            {
                textBoxResult.Text = "¬ведите корректную дату!";
            }
        }
    }
    
}