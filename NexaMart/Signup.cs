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
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
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
