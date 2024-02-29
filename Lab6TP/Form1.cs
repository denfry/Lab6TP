using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab6TP
{
    public partial class Form1 : Form
    {
        private Figure figure;
        public Form1()
        {
            InitializeComponent();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void TrapezoidButton(object sender, EventArgs e)
        {
            int x, y;
            using (var dialog = new Dialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
                {
                    figure = new Trapezoid(-dialog.X, -dialog.Y, x, y, pictureBox);
                }
            }
        }
        

        private void DrawButton(object sender, EventArgs e)
        {
            if (figure != null)
            {
                figure.Draw();
                if (figure is Trapezoid)
                {
                    label3.Text = "Активный класс: трапеция";
                }
                else if (figure is Rectangle)
                {
                    label3.Text = "Активный класс: прямоугольник";
                }
            }
            else
            {
                MessageBox.Show("Сначала создайте фигуру");
            }
        }

        private void RectangleButton(object sender, EventArgs e)
        {
            int x, y;
            using (var dialog = new Dialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
                {
                    figure = new Rectangle(dialog.X, dialog.Y, x, y, pictureBox);
                }
            }
        }

        private void ResetButton(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            textBox1.Text = null;
            textBox2.Text = null;
            label3.Text= "Активный класс:";
        }
    }
}
