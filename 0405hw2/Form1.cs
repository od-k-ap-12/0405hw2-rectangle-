using System.Drawing;
using System.Windows.Forms;

namespace _0405hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Coral,5), 10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            Rectangle Rectangle = new Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    MessageBox.Show("Outside");
                }
                else if((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    MessageBox.Show("Boundary");
                }
                else
                {
                    MessageBox.Show("Inside");
                }
            }
        }
    }
}
