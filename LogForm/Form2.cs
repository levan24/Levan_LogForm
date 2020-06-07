using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Your Email Here")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Your Email Here";

                textBox1.ForeColor = Color.Silver;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 6 || textBox1.Text.Contains("@") == false || textBox1.Text.Contains(".") == false)
            {
                MessageBox.Show("Please, enter correct Email Adress");
            }
            else
            {

                if (textBox1.Text == "Enter Your Email Here" || textBox1.Text == "")
                {
                    MessageBox.Show("Please, Enter Your Email!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sorry, but we can't restore right now. Please call Support!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Dispose();
        }
    }
}
