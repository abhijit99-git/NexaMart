using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text=="")
            {
                MessageBox.Show("Enter correct username and password","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                username.ResetText();
                password.ResetText();
                username.Focus();
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {
                signup.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
