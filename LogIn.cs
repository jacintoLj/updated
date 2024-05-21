using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Grooming
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Login_Click(object sender, EventArgs e)
        {
            if (textBox1_username.Text == "admin" && textBox2_Password.Text == "admin0220")
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
