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
using System.Data.OleDb;

namespace NexaMart
{


    public partial class Form1 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
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
                Dashboard d= new Dashboard();

                try
                {
                    con.Open();
                    string query = "Select ad_name,ad_password from Admin where ad_name='" + username.Text + "' and ad_password='" + password.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataReader read= cmd.ExecuteReader();


                    //perform
                    if (read.Read())
                    {

                        if (username.Text.Length > 7)
                        {
                            d.Adminname = "Admin";


                        }
                        else
                        {
                            d.Adminname = username.Text;

                        }

                        d.Show();
                        this.Hide();
                        username.ResetText();
                        password.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Enter correct username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex);
                }
                finally
                {
                    con.Close();
                }
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
            DialogResult res = MessageBox.Show("ㅤ      Exit?   ㅤ  ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
