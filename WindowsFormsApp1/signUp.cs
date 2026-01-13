using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class signUp : Form
    {
        string connectionString = "server=localhost;database=examedesk;uid=root;pwd=;";

        public signUp()
        {
            InitializeComponent();

            SetPlaceholder(UserName_Text, "Enter Username");
            SetPlaceholder(textBox1, "Enter Email");
            SetPlaceholder(Password_Text, "Enter Password");
            SetPlaceholder(textBox2, "Confirm Password");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIn signin = new signIn();
            signin.Show();
            this.Close();
        }

        private void Password_Text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Password_Text.Text))
            {
                label9.Visible = true;
                label9.Text = "password cannot be empty.";
            }
            else
            {
                label9.Visible = false;
            }
        }

        private void SignIn_Text_Click(object sender, EventArgs e)
        {
            string username = UserName_Text.Text.Trim();
            string email = textBox1.Text.Trim();
            string password = textBox2.Text; 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                label11.Text = "Please fill in all fields.";
                return;
            }

            string query = @"INSERT INTO Users (userName, email, password) 
                         VALUES (@Username, @Email, @Password);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            label11.Visible = true;
                            label11.ForeColor = Color.Green;
                            label11.Text = "Sign-up successful! User record created.";
                            UserName_Text.Clear();
                            textBox1.Clear();
                            Password_Text.Clear();
                            textBox2.Clear();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062)
                        {
                            label11.Text = "Error: That username or email is already taken.";
                        }
                        else
                        {
                            MessageBox.Show("Database error: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usrn_txtchanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UserName_Text.Text))
            {
                label7.Visible = true;
                label7.Text = "Username cannot be empty.";
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void emmail_changed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label8.Visible = true;
                label8.Text = "Email cannot be empty.";
            }
            else
            {
                label8.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Password_Text.Text!=textBox2.Text)
            {
                label10.Visible = true;
                label10.Text = "password does not match";
            }
            else
            {
                label10.Visible = false;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void signup_close(object sender, FormClosingEventArgs e)
        {
            signIn signin = new signIn();
            signin.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Placeholder logic
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
