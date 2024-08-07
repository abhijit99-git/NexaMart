using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.OleDb;

namespace NexaMart
{
    public partial class Signup : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
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
                try
                {
                    con.Open();
                    string query = "INSERT INTO Admin (ad_name, ad_password) VALUES ('" + signupUser.Text + "', '" + signupPass.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error "+ex);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show(" ㅤ  Sign up Sucessfully!    ㅤ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void signupPass_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ㅤ      Exit?   ㅤ  ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

    
    }
}
