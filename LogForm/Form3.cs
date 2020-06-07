using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Dispose();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
             if (textBox1.Text == "Username")
           {
               textBox1.Text = "";

               textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
         {
               textBox1.Text = "Username";

               textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           if (textBox2.Text == "Password")
          {
              textBox2.Text = "";

               textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
              textBox2.Text = "Password";

               textBox2.ForeColor = Color.Silver;

             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 6 || textBox2.Text.Length < 6)
            {
                MessageBox.Show("Only 6 characters and more!");
            }
            else
            {

                if ((textBox1.Text == "Username" || textBox1.Text == "") || (textBox2.Text == "Password" || textBox2.Text == ""))
                {
                    MessageBox.Show("Please, Enter Username And Password!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sorry, but we don't have Registration. Please call Support!");
                }
            }
        }
    }
}