using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class signIn : Form
    {
        string connectionString = "server=localhost;database=examedesk;uid=root;pwd=;";

        public signIn()
        {
            InitializeComponent();

            SetPlaceholder(UserName_Text, "Enter Username");
            SetPlaceholder(Password_Text, "Enter Password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName_Text.Text))
            {
                label7.Visible = true;
                label7.Text = "Please enter username.";
            }
            else
            {
                label7.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contactAdmin f1 = new contactAdmin();
            f1.Show();
            this.Hide();
        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signUp f2 = new signUp();
            f2.Show();
        }

        // Placeholder logic
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void SignIn_Text_Click(object sender, EventArgs e)
        {
            string username = UserName_Text.Text.Trim();
            string password = Password_Text.Text.Trim(); // Storing/using plain text password

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                label7.Visible = true;
                label8.Visible = true;
                label7.Text = "Please enter username.";
                label8.Text = "Please enter password.";
                return;
            }

            if (username == "admin" && password == "admin")
            {
                adminPanel adminPanel = new adminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else { 

                string query = "SELECT id FROM users WHERE (userName = @Username OR email=@Username) AND password = @Password;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
     
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); 

                        try
                        {
                            connection.Open();

                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                studentPanel mainForm = new studentPanel();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                label7.Visible = true;
                                label8.Visible = true;
                                label7.Text = "Invalid username or password.";
                                label8.Text = "Invalid username or password.";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void pswd_textchanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Password_Text.Text))
            {
                label8.Visible = true; 
                label8.Text = "Please enter password.";
            }
            else
            {
                label8.Visible = false;
            }
        }
    }
  
}
