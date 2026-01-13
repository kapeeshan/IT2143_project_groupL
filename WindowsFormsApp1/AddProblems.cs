using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class AddProblems : Form
    {
        public AddProblems()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            if (rdb1.Checked)
            {
                answer = 1;
            } else if (rdb2.Checked)
            {
                answer = 2;
            }else if (rdb3.Checked)
            {
                answer = 3;
            }else if (rdb4.Checked)
            {
                answer = 4;
            }

            var sql = $"INSERT INTO problems (question,choice1,choice2,choice3,choice4,correct_answer) VALUES (@question,@choice1,@choice2,@choice3,@choice4,@correct_answer)";

            using (var con = connection.GetConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql,con))
                {
                    cmd.Parameters.AddWithValue("@question",textBox1.Text);
                    cmd.Parameters.AddWithValue("@choice1", txt1.Text);
                    cmd.Parameters.AddWithValue("@choice2", txt2.Text);
                    cmd.Parameters.AddWithValue("@choice3", txt3.Text);
                    cmd.Parameters.AddWithValue("@choice4", txt4.Text);
                    cmd.Parameters.AddWithValue("@correct_answer", answer);
        

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Problem Added");
                    } else
                    {
                        MessageBox.Show("Error in Data Entered");

                    }
                }
            }
                







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPanel admin = new adminPanel();
            this.Hide();
            admin.Show();
        }
    }
}
