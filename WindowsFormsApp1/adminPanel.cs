using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminPanel : Form
    {
        private string connectionString = "Server=localhost;Database=examedesk;User ID=root;Password=;";
        bool n;
        Connection connection1 = new Connection();
        public adminPanel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                // Define the SQL query
                string query = "SELECT id, username,email FROM Users;";

                // Use 'using' statements for automatic resource disposal
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // MySqlDataAdapter is the key component to fill a DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // DataTable will hold the data in memory
                            DataTable dataTable = new DataTable();

                            try
                            {
                                connection.Open();

                                // Fill the DataTable using the DataAdapter
                                adapter.Fill(dataTable);

                                // Bind the DataTable to the DataGridView
                                dataGridView1.DataSource = dataTable;

                                // Optional: Ensure columns are automatically generated and read-only
                                dataGridView1.AutoGenerateColumns = true;
                                dataGridView1.ReadOnly = true;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error loading data: {ex.Message}");
                            }
                        }
                    }
                }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Define the SQL query
            string query = "SELECT id,subject1,subject2,subject3,subject4 FROM result;";

            // Use 'using' statements for automatic resource disposal
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // MySqlDataAdapter is the key component to fill a DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // DataTable will hold the data in memory
                        DataTable dataTable = new DataTable();

                        try
                        {
                            connection.Open();

                            // Fill the DataTable using the DataAdapter
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;

                            // Optional: Ensure columns are automatically generated and read-only
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.ReadOnly = false;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading data: {ex.Message}");
                        }
                        dataGridView1.ReadOnly = false;

                        if (n)
                        {
                            try
                            {
                                adapter.Update(dataTable);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error saving changes: " + ex.Message);
                            }
                        }
                    }
                }
            }



        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            n = true;
        }

        private void pannel_close(object sender, FormClosingEventArgs e)
        {
            WindowsFormsApp1.signIn signInForm = new WindowsFormsApp1.signIn();
            signInForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM  quiz";
            using (var con = connection1.GetConnection())
            {
                con.Open();
                using (MySqlDataAdapter addapter = new MySqlDataAdapter(sql, con))
                {
                    DataTable dataTable = new DataTable();
                    addapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Hide();
           AddProblems problems = new AddProblems();
            problems.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM  problems";
            using (var con = connection1.GetConnection())
            {
                con.Open();
                using (MySqlDataAdapter addapter = new MySqlDataAdapter(sql, con))
                {
                    DataTable dataTable = new DataTable();
                    addapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }
    }

}
