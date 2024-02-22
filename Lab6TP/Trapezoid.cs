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
        public Trapezoid(int width, int height, PictureBox pictureBox) 
        {
            Width = width; 
            Height = height;
            this.pictureBox = pictureBox;
        }
        public override void Draw()
        {
            Graphics g = pictureBox.CreateGraphics();
            
            
            g.Clear(Color.White);

            
            int x1 = (pictureBox.Width - Width) / 2;
            int x2 = x1 + Width;
            int x3 = x1 + (Width - Width / 2);
            int y1 = pictureBox.Height - Height;
            int y2 = pictureBox.Height;

            
            Point[] points =
            {
                new Point(x1, y2),
                new Point(x2, y2),
                new Point(x3, y1),
                new Point(x1 + Width / 2, y1)
            };

            
            g.DrawPolygon(Pens.Black, points);
        }
    }
}
