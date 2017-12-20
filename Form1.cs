using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void begin()
        {
         string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("hoe groot moet uw bord worden? ", "grootte", "6");
            int v = int.Parse(UserAnswer);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Brushes.Black);

            for (int y = 0; y <= v; ++y)
            {
                e.Graphics.DrawLine(blackPen, 0, y * 50, v * 50, y * 50);
            }

            for (int x = 0; x <= v; ++x)
            {
                e.Graphics.DrawLine(blackPen, x * 50, 0, x * 50, v * 50);
            }
        }

        public void Form1_mouseclick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            Graphics g;
            g = this.CreateGraphics();

            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);

            Drawcircle(arg, x, y, 90, 90);
        }
        public void Drawcircle(PaintEventArgs e, int x, int y, int width, int height)
        {
            width = 90;
            height = 90;
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawEllipse(pen, x - 100 / 2, y - 100 / 2, 90, 90);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
