using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6TP
{
    public partial class Dialog : Form
    {
        public int X {  get; private set; }
        public int Y { get; private set; }
        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int width) && int.TryParse(textBox2.Text, out int height))
            {
                
                X = width;
                Y = height;

                
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректные значения для ширины и высоты");
            }
        }
    }
}
