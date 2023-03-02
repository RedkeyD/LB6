using PROJECT5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form4 : Form
    {
        public Form4()
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
            double xn, xk, x, h;

            xn = Double.Parse(textBox1.Text);
            xk = Double.Parse(textBox2.Text);

            h = (xk - xn) / 10;

            for (x = xn; x <= xk; x += h) 
            {
                textBox4.Text = "Y = " + Convert.ToString(LibMy.Project31(xn, xk, x)) + "S = " + Convert.ToString(LibMy.Project3(xn, xk, x));
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
