using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string username = txtusername.Text;
            string password = txtpassword.Text;

           
            SqlConnection conn = new SqlConnection("Data Source=Tyrone;Initial Catalog=TYDB;Integrated Security=True");
            
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Role FROM Users WHERE Username=@Username AND Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string role = reader.GetString(0);
                MessageBox.Show("Welkom, " + username);

                User user = new User(username, role);
                new Form2(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

            reader.Close();
            conn.Close();
        }


    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            new Form3().Show();
             Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
