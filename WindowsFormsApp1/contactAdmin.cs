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
    public partial class contactAdmin : Form
    {
        public contactAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contact_close(object sender, FormClosingEventArgs e)
        {
            signIn signin= new signIn();
            signin.Show();
        }
    }
}
