namespace WinForms_DZ_02
{
    public partial class Form1 : Form
    {
        private Panel panel { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMouseDown(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rectangle = new Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);
                if (rectangle.Contains(rectangle.Location))
                {
                    MessageBox.Show("Точка находится внутри прямоугольника.");
                }
                else if (e.Location.X < 10 || e.Location.X > this.ClientSize.Width - 10 || e.Location.Y < 10 || e.Location.Y > this.ClientSize.Height - 10)
                {
                    MessageBox.Show("Точка находится снаружи прямоугольника.");
                }
                else
                {
                    MessageBox.Show("Точка находится на границе прямоугольника.");
                }
                
                if (Control.ModifierKeys == Keys.Control)
                {
                    this.Close();
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Текущие координаты :  X = {e.X} , Y = {e.Y}";
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}");
        }
    }
}