using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6TP
{
    internal class Rectangle : Figure
    {
        private PictureBox pictureBox;
        public Rectangle(int width, int height, int x, int y, PictureBox pictureBox)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
            this.pictureBox = pictureBox;
        }
        public override void Draw()
        {
            using (Graphics g = pictureBox.CreateGraphics())
            using (Pen pen = new Pen(Color.Black))
            {
                g.Clear(Color.White);
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }


    }
}
