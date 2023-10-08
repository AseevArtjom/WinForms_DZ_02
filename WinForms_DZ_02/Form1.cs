namespace WinForms_DZ_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBox1.Text, out DateTime selectedDate))
            {
                string dayOfWeek = selectedDate.ToString("dddd", new System.Globalization.CultureInfo("ru-RU"));
                MessageBox.Show($"���� ������: {dayOfWeek}", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("��.��.����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}