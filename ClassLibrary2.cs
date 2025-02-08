using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ClassLibrary2
{
    public abstract class Shape
    {
        protected int X;
        protected int Y;
        protected Color ShapeColor;
        protected Graphics CompGraphics;

        public Shape(int x, int y, Color shapecolor, Graphics g)
        {
            X = x;
            Y = y;
            ShapeColor = shapecolor;
            CompGraphics = g;
        }

        public abstract void Draw();
    }
    public class Line : Shape
    {

        protected int X2;
        protected int Y2;

        public Line(int x1, int y1, int x2, int y2, Color shapecolor, Graphics g) : base(x1, y1, shapecolor, g)
        {
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw()
        {
            Pen pen = new Pen(ShapeColor, 5);
            CompGraphics.DrawLine(pen, X, Y, X2, Y2);
        }
    }
    public class Circle : Shape
    {
        protected int X2;
        protected int Y2;
        public Circle(int x1, int y1, int x2, int y2, Color shapecolor, Graphics g) : base(x1, y1, shapecolor, g)
        {
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw()
        {
            Pen pen = new Pen(ShapeColor, 5);
            CompGraphics.DrawEllipse(pen, X, Y, X2-X, Y2 - Y);
        }
    }
    public class Ellipse : Circle
    {

        public Ellipse(int x1, int y1, int x2, int y2, Color shapecolor, Graphics g) : base(x1, y1, x2, y2, shapecolor, g)
        {
        }

        public override void Draw()
        {
            Pen pen = new Pen(ShapeColor, 5);
            CompGraphics.DrawEllipse(pen, X, Y, X2 - X, Y2 - Y);
        }
    }
    public class Rectanglec : Line
    {
        public Rectanglec(int x1, int y1, int x2, int y2, Color shapecolor, Graphics g) : base(x1, y1, x2, y2, shapecolor, g)
        {
            X2 = x2;
            Y2 = y2;
        }
        public override void Draw()
        {
            Pen pen = new Pen(ShapeColor, 5);
            CompGraphics.DrawRectangle(pen, X, Y, X2 - X, Y2 - Y);
        }
    }
}

