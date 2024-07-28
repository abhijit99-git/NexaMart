using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NexaMart
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }


        private void Signup_Load(object sender, EventArgs e)
        {
        
        }
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("   Exit?   " , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
    
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (signupUser.Text == "" || signupPass.Text == "")
            {
                MessageBox.Show("Enter correct username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signupUser.ResetText();
                signupPass.ResetText();
                signupUser.Focus();
            }
            else
            {
                MessageBox.Show(" Sign up Sucessfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void signupPass_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("   Exit?   ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
