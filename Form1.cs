using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics graphics = pictureBox1.CreateGraphics();
            List<Shape> shapes = new List<Shape>();
            Random random = new Random();
            int k = 20;
            for (int i = 0; i < k; i++)
            {
                int x1 = random.Next(pictureBox1.Width);
                int x2 = random.Next(pictureBox1.Width);
                int y1 = random.Next(pictureBox1.Height);
                int y2 = random.Next(pictureBox1.Height);
                int red = random.Next(256); int green = random.Next(256);
                int blue = random.Next(256);
                if (random.Next(0, 10) == 5)
                {
                    shapes.Add(new Line(x1, y1, x2, y2, Color.FromArgb(red, green, blue), graphics));
                }
                else if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) shapes.Add(new Circle(x1, y1, x2, y2, Color.FromArgb(red, green, blue), graphics));
                else if (random.Next(0, 2) == 1) shapes.Add(new Ellipse(x1, y1, x2, y2, Color.FromArgb(red, green, blue), graphics));
                else shapes.Add(new Rectanglec(x1, y1, x2, y2, Color.FromArgb(red, green, blue), graphics));
                foreach (Shape shape in shapes) 
                {
                    shape.Draw();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.Clear(DefaultBackColor);
            
        }
    }
}
