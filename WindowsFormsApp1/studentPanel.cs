using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class studentPanel : Form
    {
        public studentPanel()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sql = $"SELECT * FROM  quiz";
            using (var con = connection.GetConnection())
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizForm quizform = new QuizForm();
            quizform.Show();
        }
    }
}
