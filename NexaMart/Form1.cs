using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace NexaMart
{


    public partial class Form1 : Form
    {
        public Form1()
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



        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text=="")
            {
                MessageBox.Show("Enter correct username and password","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                username.ResetText();
                password.ResetText();
                username.Focus();
            }
            else
            {
               // System.Diagnostics.Process.Start("https://www.linkedin.com/feed/");
               Dashboard d= new Dashboard();
                d.Show();
                this.Hide();
                username.ResetText();
                password.ResetText();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("   Exit?   ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public Point mouseLocation;
        private void mouse_Down(object sender, MouseEventArgs e)
        {

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {

        }
    }
}
