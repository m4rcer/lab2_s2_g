using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2s_g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            Point[] polyPoints = {
                new Point(300, 350),
                new Point(500, 350),
                new Point(600, 200),
                new Point(400, 50),
                new Point(100, 150)
            };

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(polyPoints);

            Region region = new Region(path);

            Pen pen = Pens.Black;
            g.DrawPath(pen, path);

            g.SetClip(region, CombineMode.Replace);

            for (int i = 20; i < pictureBox1.Height; i += 20)
            {
                g.DrawLine(Pens.Red, new Point(0, i), new Point(pictureBox1.Width, i));
            }
        }
    }
}
