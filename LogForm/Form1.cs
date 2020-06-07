using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

            //  textBox2.MaxLength = 8;
            //  textBox1.MaxLength = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (textBox1.Text.Length < 6 || textBox2.Text.Length  < 6)
            {
                MessageBox.Show("Only 6 characters and more!");
            }
         else { 
                    
                if ((textBox1.Text == "Username" || textBox1.Text == "") || (textBox2.Text == "Password" || textBox2.Text == ""))
            {
                MessageBox.Show("Please, Enter Username And Password!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sorry, but your can't sing in right now. Please call Support!");
            }
        }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {


            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";

                textBox2.ForeColor = Color.Silver;

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

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
            
        }


        private void Form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}