using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6TP
{
    internal class Trapezoid : Figure
    {
        private PictureBox pictureBox;
        public Trapezoid(int width, int height, int x, int y, PictureBox pictureBox)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
            this.pictureBox = pictureBox;
        }
        public override void Draw()
        {
            
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            
            g.Clear(Color.White);
            int x1 = X + (Width * Width / Height);
            int x2 = (X + Width) - (Width * Width / Height);
            int x3 = X;
            int x4 = X + Width;
            int y1 = Y;
            int y2 = Y;
            int y3 = Y + Height;
            int y4 = Y + Height;

            Point[] points =
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3),
                new Point(x4, y4)
            };

            g.DrawPolygon(pen, points);
            pen.Dispose();
            g.Dispose();
        }
    }
    
}
