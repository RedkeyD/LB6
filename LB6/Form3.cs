using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT5;

namespace LB6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B;
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали вычисляемую функцию");
            }
            else
            {
                try
                {
                    A = Convert.ToDouble(textBox1.Text);
                    B = Convert.ToDouble(textBox2.Text);

                    textBox4.Text = Convert.ToString(LibMy.Project2(A, B, comboBox1.SelectedIndex));
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Неверный формат введенных данных");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
