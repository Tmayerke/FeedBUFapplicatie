using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUFapplicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "student" && txtpassword.Text == "student")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect, try again");
                txtusername.Clear();
                txtpassword.Clear();
                txtusername.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
