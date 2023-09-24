namespace WinForms_DZ_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i.ToString() != textBox1.Text)
            {
                if (i > 2000)
                {
                    return;
                }
                else { i++; }
            }
            MessageBox.Show(i.ToString());
            var resultDialog = MessageBox.Show("Play again?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Yes)
            {
                return;
            }
            else if(resultDialog == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                          
        }
    }
}