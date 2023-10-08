using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_DZ_02
{
    public partial class Form1 : Form
    {
        private const int staticSize = 50;
        private const int staticSpeed = 5;
        private Point staticLocation;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            staticLocation = GenerateRandomLocation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoveStaticToLocation(staticLocation);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int distanceX = e.X - (staticLocation.X + staticSize / 2);
            int distanceY = e.Y - (staticLocation.Y + staticSize / 2);

            if (Math.Abs(distanceX) < staticSize && Math.Abs(distanceY) < staticSize)
            {
                staticLocation = GenerateRandomLocation();
                MoveStaticToLocation(staticLocation);
            }
        }
        private Point GenerateRandomLocation()
        {
            int maxX = ClientSize.Width - staticSize;
            int maxY = ClientSize.Height - staticSize;
            return new Point(random.Next(maxX), random.Next(maxY));
        }

        private void MoveStaticToLocation(Point location)
        {
            button1.Location = location;
        }
    }
}