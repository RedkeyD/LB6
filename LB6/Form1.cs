namespace LB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }

    }
}