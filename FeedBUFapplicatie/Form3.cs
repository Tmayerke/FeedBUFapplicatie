using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FeedBUFapplicatie
{
    public partial class Form3 : Form
    {
        private const string ConnectionString = @"Data Source=Tyrone;Initial Catalog=TYDB;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Users (Username, Password, Name, Surname, Birthday, Email, Role) " +
                            "VALUES (@Username, @Password, @Name, @Surname, @Birthday, @Email, @Role)";

                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@Birthday", dtpBirthday.Value);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Role", cmbRole.SelectedItem);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("User registered successfully!");
                Hide();
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Alle velden moeten ingevuld zijn!");
            }
        }

        private bool ValidateFields()
        {
            return
                !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtSurname.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                cmbRole.SelectedItem != null;
        }

        private void regcancelbtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }
    }
}
