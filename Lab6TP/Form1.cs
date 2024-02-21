using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab6TP
{
    public partial class Form1 : Form
    {
        private Figure figure;
        public Form1()
        {
            InitializeComponent();
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new Dialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    figure = new Trapezoid(dialog.X, dialog.Y, pictureBox);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (figure != null)
            {
                figure.Draw();
            }
            else
            {
                MessageBox.Show("Сначала создайте фигуру");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figure = new Rectangle(0, 0);

            
            using (var dialog = new Dialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    figure.Width = dialog.X;
                    figure.Height = dialog.Y;
                }
            }
        }
    }
}
